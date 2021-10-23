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
    //[XmlRoot("Producto")]
    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string FechaVencimiento { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Nombre", Nombre);
            info.AddValue("Cantidad", Cantidad);
            info.AddValue("FechaVencimiento", FechaVencimiento);
        }

        public Producto(SerializationInfo info, StreamingContext context)
        {
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Cantidad = (int)info.GetValue("Cantidad", typeof(int));
            FechaVencimiento = (string)info.GetValue("FechaVencimiento", typeof(string));
        }

        public Producto(string nom, int cant, string fv)
        {
            Nombre = nom;
            Cantidad = cant;
            FechaVencimiento = fv;
        }

        public Producto() { }
    }
}
