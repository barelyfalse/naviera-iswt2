using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;
using NavieraISWT2.models;

namespace NavieraISWT2
{
    public class SqliteDataAccess
    {
        public static List<Producto> LoadProducts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Producto>("select id_producto, nombre as Nombre, cantidad as Cantidad, peso as Peso, valor_referencia as ValorReferencia, categoria as Categoria, fecha_vencimiento as FechaVencimiento, id_envio from Productos where ingresado = false", new DynamicParameters());
                return output.ToList();
            }
        }

        public static int GetProductosOnHold()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var count = cnn.Query<long>("select count(*) as Count from Productos where Ingresado = false");
                return (int)count.ToArray()[0];
            }
        }

        public static void SaveShipment(Envio env)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //save client
                var clientId = cnn.Query<long>("insert into Clientes (nombre, direccion, telefono1, telefono2) values (@Nombre, @Direccion, @Telefono1, @Telefono2); SELECT last_insert_rowid();", env.Cliente);

                //save ship
                var sendId = cnn.Query<long>("insert into Envios (id_cliente) values (" + clientId.ToArray()[0] + "); SELECT last_insert_rowid();");

                //save products
                foreach (Producto p in env.Productos)
                {
                    cnn.Execute("insert into Productos (nombre, cantidad, peso, valor_referencia, categoria, fecha_vencimiento, id_envio, ingresado) values (@Nombre, @Cantidad, @Peso, @ValorReferencia, 1, @FechaVencimiento, " + sendId.ToArray()[0] + ", false)", p);
                }

                //cnn.Execute("insert into Productos (nombre, cantidad, categoria, fecha_vencimiento, id_envio, ingresado) values (@Nombre, @Cantidad, 1, @FechaVencimiento, false)", prod);
            }
        }

        public static void EntryNote(string container, string plate, string driver, string time, int[] prodIds, int bay)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //save entrynote
                var entryId = cnn.Query<long>(
                    String.Format(
                        "insert into NotasDeIngreso (fecha, contenedor, placa_camion, conductor, tiempo_apertura) values ('{0}', '{1}', '{2}', '{3}', '{4}'); SELECT last_insert_rowid();",
                        DateTime.Now,
                        container,
                        plate,
                        driver,
                        time
                    ));

                //Console.WriteLine(entryId.ToArray()[0]);

                foreach(int prodId in prodIds)
                {
                    cnn.Query(
                        String.Format(
                            "update Productos set bahia = {0}, ingresado = 1, id_nota_ingreso = {1} where id_producto = {2}",
                            bay + 1,
                            entryId.ToArray()[0],
                            prodId
                            )
                        );
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
