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
        public static List<Producto> LoadNotEnteredProducts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Producto>("select id_producto, nombre as Nombre, cantidad as Cantidad, peso as Peso, valor_referencia as ValorReferencia, fecha_vencimiento as FechaVencimiento, id_envio from Productos where ingresado = false", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Producto> LoadStoredProducts(int bay)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Producto>(
                    "select Productos.id_producto, " +
                    "Productos.nombre as Nombre, " +
                    "Productos.cantidad as Cantidad, " +
                    "Productos.peso as Peso, " +
                    "Productos.valor_referencia as ValorReferencia, " +
                    "Productos.fecha_vencimiento as fechaVencimiento, " +
                    "Productos.id_envio, " +
                    "Categorias.nombre as Categoria " +
                    "from Productos " +
                    "inner join Categorias " +
                    "on Productos.categoria = Categorias.id_categoria " +
                    "where Productos.ingresado = true " +
                    "and Productos.bahia = "+bay+"; "
                    , new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<KeyValuePair<int, string>> LoadCategories()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<KeyValuePair<int, string>> catgs = new List<KeyValuePair<int, string>>();
                var output = cnn.Query("select * from Categorias", new DynamicParameters());
                foreach (IDictionary<string, object> obj in output)
                {
                    catgs.Add(new KeyValuePair<int, string>(int.Parse(((object[])obj.Values)[0].ToString()), (string)(((object[])obj.Values)[1])));
                }
                return catgs;
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

        public static void EntryNote(string container, string plate, string driver, string time, int[] prodIds, int[] prodCats, int bay)
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

                for(int i = 0; i < prodIds.Length; i++)
                {
                    cnn.Query(
                        String.Format(
                            "update Productos set categoria = {0}, bahia = {1}, ingresado = 1, id_nota_ingreso = {2} where id_producto = {3}",
                            prodCats[i],
                            bay + 1,
                            entryId.ToArray()[0],
                            prodIds[i]
                            )
                        );
                }
            }
        }

        public static void RemoveNote(string plate, string driver, string time, int[] prodIds)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //save entrynote
                var entryId = cnn.Query<long>(
                    String.Format(
                        "insert into NotasDeSalida (fecha, placa_camion, conductor, tiempo_apertura) values ('{0}', '{1}', '{2}', '{3}'); SELECT last_insert_rowid();",
                        DateTime.Now,
                        plate,
                        driver,
                        time
                    ));

                //Console.WriteLine(entryId.ToArray()[0]);

                for (int i = 0; i < prodIds.Length; i++)
                {
                    cnn.Query(
                        String.Format(
                            "update Productos set bahia = null, ingresado = 0, id_nota_ingreso = null, id_nota_salida = {0} where id_producto = {1}",
                            entryId.ToArray()[0],
                            prodIds[i]                            
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
