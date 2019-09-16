using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SIS_Ga2.Entity
{
    public class Proyecto
    {
        public int idProyecto { get; set; }
        public int idUsuario { get; set; }
        public int idReglamento { get; set; }
        public int idTipoDiseno { get; set; }
        public string CodProyecto { get; set; }
        public string FecProyecto { get; set; }
        public string Ubicacion { get; set; }
        public string NumDiseno { get; set; }
        public string Tramo { get; set; }
        public bool Estado { get; set; }
        public string Reglamento { get; set; }
        public string TipoDiseno { get; set; }
    }
}
