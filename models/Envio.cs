using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace NavieraISWT2.models
{
    public class Envio
    {
        public Cliente Cliente { get; set; }
        public Producto[] Productos { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Cliente", Cliente);
            info.AddValue("Productos", Productos);
        }

        public Envio(SerializationInfo info, StreamingContext context)
        {
            Cliente = (Cliente)info.GetValue("Cliente", typeof(Cliente));
            Productos = (Producto[])info.GetValue("Productos", typeof(Producto[]));
        }

        public Envio(Cliente cli, Producto[] prods)
        {
            Cliente = cli;
            Productos = prods;
        }

        public Envio() { }
    }
}
