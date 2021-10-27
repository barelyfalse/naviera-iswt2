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
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", Id);
            info.AddValue("Nombre", Nombre);
            info.AddValue("Direccion", Direccion);
            info.AddValue("Telefono1", Telefono1);
            info.AddValue("Telefono2", Telefono2);
        }

        public Cliente(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("ID", typeof(int));
            Nombre = (string)info.GetValue("Nombre", typeof(string));
            Direccion = (string)info.GetValue("Direccion", typeof(string));
            Telefono1 = (string)info.GetValue("Telefono1", typeof(string));
            Telefono1 = (string)info.GetValue("Telefono2", typeof(string));
        }

        public Cliente(int idd, string nom, string dir, string tel1, string tel2)
        {
            Id = idd;
            Nombre = nom;
            Direccion = dir;
            Telefono1 = tel1;
            Telefono2 = tel2;
        }

        public Cliente() { }
    }
}
