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
                var output = cnn.Query<Producto>("select id_producto, nombre as Nombre, cantidad as Cantidad, categoria as Categoria, fecha_vencimiento as FechaVencimiento, id_envio from Productos where ingresado = false", new DynamicParameters());
                //var outp = Dyn2Dict(output);
                return output.ToList();
            }
        }

        public static List<Dictionary<string, object>> Dyn2Dict(IEnumerable<dynamic> dynObj)
        {
            List<Dictionary<string, object>> dictionary = new List<Dictionary<string, object>>();
            foreach(dynamic d in dynObj)
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(d))
                {
                    object obj = propertyDescriptor.GetValue(d);

                    if (!dict.ContainsKey(propertyDescriptor.Name))
                    {
                        dict.Add(propertyDescriptor.Name, obj);
                    }
                }
                dictionary.Add(dict);
            }
            
            return dictionary;
        }

        public static int GetProductosOnHold()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var count = cnn.Query<long>("select count(*) as Count from Productos where Ingresado = false");
                return (int)count.ToArray()[0];
            }
        }

        public static void SaveProduct(Producto prod)
        {
            int idEnvio = 1; //ultimo id valido de la tabla envios
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var key = cnn.Query<long> ("insert into Productos (nombre, cantidad, categoria, fecha_vencimiento, id_envio, ingresado) values (@Nombre, @Cantidad, 1, @FechaVencimiento, "+idEnvio+ ", false); SELECT last_insert_rowid();", prod);

                //Console.WriteLine(key.ToArray()[0]);
            }
        }

        public static void GuardarEnvio(Envio env)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //save client
                var clientId = cnn.Query<long>("insert into Clientes (nombre, direccion, telefono1, telefono2) values (@Nombre, @Direccion, @Telefono1, @Telefono2); SELECT last_insert_rowid();", env.Cliente);

                //save send
                var sendId = cnn.Query<long>("insert into Envios (id_cliente) values (" + clientId.ToArray()[0] + "); SELECT last_insert_rowid();");

                //save products
                foreach (Producto p in env.Productos)
                {
                    cnn.Execute("insert into Productos (nombre, cantidad, categoria, fecha_vencimiento, id_envio, ingresado) values (@Nombre, @Cantidad, 1, @FechaVencimiento, " + sendId.ToArray()[0] + ", false)", p);
                }

                //cnn.Execute("insert into Productos (nombre, cantidad, categoria, fecha_vencimiento, id_envio, ingresado) values (@Nombre, @Cantidad, 1, @FechaVencimiento, false)", prod);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
