using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
   public class BEDiseno
    {
        public int idDiseno { get; set; }
        public int idProyecto { get; set; }
        public string NumeroDiseno { get; set; }
        public double Fecha { get; set; }
        public bool Estado { get; set; }
        public int idTramo { get; set; }
        public int idReglamento { get; set; }
        public int IdTipoDiseno { get; set; }
        public int idDistrito { get; set; }      
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
