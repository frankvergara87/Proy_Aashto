using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class BESNRequerido
    {
        public int idSN { get; set; }
        public int idDiseno { get; set; }
        public decimal SNRequerido { get; set; }
        public decimal N18Calc1 { get; set; }
        public decimal N18Calc2 { get; set; }
        public decimal N18Nom1 { get; set; }
        public decimal N18Nom2 { get; set; }
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
