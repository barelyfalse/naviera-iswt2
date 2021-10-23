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
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread t = new Thread(XMLListening);
            t.Start();
            //ManifestSerialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

        static void ManifestSerialize()
        {
            Manifiesto m = new Manifiesto(
                13, 
                new Envio[] { 
                    new Envio(
                        new Cliente(1, "cliente", "calle 1", "123456", "123456"), 
                        new Producto[] {
                            new Producto("prod1", 3, "01-01-2022"),
                            new Producto("prod2", 6, "02-02-2022"),
                            new Producto("prod3", 6, "03-03-2022")
                        }
                    ),
                    new Envio(
                        new Cliente(2, "cliente2", "calle 2", "123456", "123456"),
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

        static void Deserialize(string obj)
        {
            Manifiesto m = (Manifiesto)obj.XmlDeserializeFromString<Manifiesto>();
            Console.WriteLine("Info got deserialized!");
            //Console.WriteLine(m.Envios[1].Cliente.Nombre);
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
            // Get the data from the HTTP stream
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();

            Deserialize(body);

            // In BODY lays all our hopes
            // Console.WriteLine(body);

            byte[] b = Encoding.UTF8.GetBytes("OK");
            context.Response.StatusCode = 200;
            context.Response.KeepAlive = false;
            context.Response.ContentLength64 = b.Length;

            var output = context.Response.OutputStream;
            output.Write(b, 0, b.Length);
            context.Response.Close();
        }
    }
}
