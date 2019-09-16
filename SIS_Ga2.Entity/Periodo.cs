using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class Periodo
    {
        public int idPeriodo { get; set; }
        public string DescripcionPeriodo { get; set; }
        public int CantPeriodo { get; set; }
        public bool Estado { get; set; }
    }
}
