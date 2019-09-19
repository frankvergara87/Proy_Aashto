using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class BECapaPavimento
    {
        public int idCapaPavimento { get; set; }
        public int idDiseno { get; set; }
        public int idTipoDiseno { get; set; }
        public decimal ValorME { get; set; }
        public decimal ValorMR { get; set; }
        public decimal ValorCBR { get; set; }
        public decimal FC { get; set; }
        public decimal EspesorCM { get; set; }
        public decimal EspesorPulgadas { get; set; }
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
