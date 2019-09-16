using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SIS_Ga2.Entity
{
    public class ParametrosDiseno
    {
        public int idParametroDiseno { get; set; }
        public int idParametro { get; set; }
        public int idTipoDiseno { get; set; }
        public bool Estado { get; set; }
        public string TipoDiseno { get; set; }
        public string DescripcionParametro { get; set; }
    }
}
