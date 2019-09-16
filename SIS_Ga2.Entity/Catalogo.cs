using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class Catalogo
    {
        public int IdCatalogo { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public bool Estado { get; set; }

    }
}
