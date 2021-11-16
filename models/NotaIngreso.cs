using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavieraISWT2.models
{
    public class NotaIngreso
    {
        public int ID { get; set; }
        public string Fecha { get; set; }
        public int Contenedor { get; set; }
        public string PlacaCamion { get; set; }
        public string Conductor { get; set; }
        public string TiempoApertura { get; set; }

        public NotaIngreso() { }
    }
}
