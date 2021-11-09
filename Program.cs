using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using NavieraISWT2.models;

namespace NavieraISWT2
{
    static class Program
    {
        static Thread xmlListeningThread;

        [STAThread]
        static void Main()
        {
            xmlListeningThread = new Thread(XMLListening);
            xmlListeningThread.IsBackground = true;
            xmlListeningThread.Start();
            //xmlListeningThread.Abort();
            //ManifestSerialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NavForm());
        }

        static void ManifestSerialize()
        {
            Manifiesto m = new Manifiesto(
                13, 
                new Envio[] { 
                    new Envio(
                        new Cliente("cliente", "calle 1", "123456", "123456"), 
                        new Producto[] {
                            new Producto("prod1", 3, "01-01-2022"),
                            new Producto("prod2", 6, "02-02-2022"),
                            new Producto("prod3", 6, "03-03-2022")
                        }
                    ),
                    new Envio(
                        new Cliente("cliente2", "calle 2", "123456", "123456"),
                        new Producto[] {
                            new Producto("prod4", 3, "01-01-2022"),
                            new Producto("prod5", 2, "02-02-2022")
                        }
                    )
                }
            );

            XmlSerializer serializer = new XmlSerializer(typeof(Manifiesto));
            using (TextWriter tw = new StreamWriter(@".\man1.xml"))
            {
                serializer.Serialize(tw, m);
            }
            Console.WriteLine("Info got serialized");
        }

        static void ManifestDeserialize(string obj)
        {
            Manifiesto m = (Manifiesto)obj.XmlDeserializeFromString<Manifiesto>();
            Console.WriteLine("Info got deserialized!");
            //meter productos a la tabla productos
            foreach(Envio e in m.Envios)
            {
                SqliteDataAccess.GuardarEnvio(e);
            }

            Console.WriteLine("ships saved");

            //SqliteDataAccess.SaveProduct(m.Envios[0].Productos[0], 1);

        }

        public static T XmlDeserializeFromString<T>(this string objectData)
        {
            return (T)XmlDeserializeFromString(objectData, typeof(T));
        }

        public static object XmlDeserializeFromString(this string objectData, Type type)
        {
            var serializer = new XmlSerializer(type);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }

        static void XMLListening()
        {
            var prefix = "http://*:4333/carga/";
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(prefix);
            try
            {
                listener.Start();
                Console.WriteLine("Listening");
            }
            catch (HttpListenerException hlex)
            {
                Console.WriteLine(hlex.Message);
                return;
            }

            while (listener.IsListening)
            {
                var context = listener.GetContext();
                ProcessRequest(context);
            }
            listener.Close();
        }

        private static void ProcessRequest(HttpListenerContext context)
        {
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();
            // In body var lays all our hopes

            ManifestDeserialize(body);

            byte[] b = Encoding.UTF8.GetBytes("OK");
            context.Response.StatusCode = 200;
            context.Response.KeepAlive = false;
            context.Response.ContentLength64 = b.Length;

            var output = context.Response.OutputStream;
            output.Write(b, 0, b.Length);
            context.Response.Close();
        }

        public static void StopHttpServer()
        {
            Console.WriteLine("Sopping http listening");
            xmlListeningThread.Abort();
        }
    }
}
