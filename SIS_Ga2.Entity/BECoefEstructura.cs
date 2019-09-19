using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class BECoefEstructura
    {
        public int idCoeficiente { get; set; }
        public int idDiseno { get; set; }
        public int idTipoPavimento { get; set; }
        public double CoefDrenaje { get; set; }
        public double CoefEstructural { get; set; } 
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
