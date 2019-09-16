using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Web;

namespace SIS_Ga2.Entity
{
    [DataContract]
    public class Aplicacion
    {
        public int IdAplicacion { get; set; }
        public string NombreAplicacion { get; set; }
        public string ImagenUrl { get; set; }
        public string ColorBoton { get; set; }
        public bool Estado { get; set; }

        public HttpPostedFileBase upload { get; set; }
    }
}
