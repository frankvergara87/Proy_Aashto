using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class Sistema
    {
        public int idUsuario { get; set; }
        public string cuenta { get; set; }
        public string clave { get; set; }
        public int idAplicacion { get; set; }
        public int idProyecto { get; set; }
        public string CodProyecto { get; set; }
        public int idReglamento { get; set; }
        public string Reglamento { get; set; }
        public int idTipoDiseno { get; set; }
        public string TipoDiseno { get; set; }


    }
}
