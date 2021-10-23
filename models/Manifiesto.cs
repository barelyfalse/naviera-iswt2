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
    //[XmlRoot("Manifiesto")]
    public class Manifiesto
    {
        public int Barco { get; set; }
        //[XmlArray("Envios")]
        //[XmlArrayItem("Envio")]
        public Envio[] Envios { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Barco", Barco);
            info.AddValue("Envios", Envios);
        }

        public Manifiesto(SerializationInfo info, StreamingContext context)
        {
            Barco = (int)info.GetValue("Barco", typeof(int));
            Envios = (Envio[])info.GetValue("Envios", typeof(Envio[]));
        }

        public Manifiesto(int b, Envio[] env)
        {
            Barco = b;
            Envios = env;
        }

        public Manifiesto() {
            Barco = 0;
            Envios = null;
        }
    }
}
