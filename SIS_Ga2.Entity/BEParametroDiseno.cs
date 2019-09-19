using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class BEParametroDiseno
    {
        public int idParametro{ get; set; }
        public int idDiseno { get; set; }
        public int idPeriodo { get; set; }
        public decimal ESAL { get; set; }
        public decimal Confiabilidad { get; set; }
        public decimal ErrorCombinac { get; set; }
        public decimal ModuloResilencia { get; set; }
        public decimal ServInicial { get; set; }
        public decimal ServFinal { get; set; }
        public decimal DiferenciaServ { get; set; }
        public decimal DesvEstandar { get; set; }
        public decimal ResCompresion { get; set; }

        public decimal ModuloRotura { get; set; }
        public decimal ModuloElasticidad { get; set; }
        public decimal CoefTransfe { get; set; }
        public decimal ModuloReaccion { get; set; }
        public decimal CoefDrenaje { get; set; }
        public int idRepetEquiva { get; set; }
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }
    }
}
