//Generador de Codigo
using System;
using System.Collections.Generic;
using System.Data;


namespace SIS_Ga2.Entity
{
    public class Unidadmedida
    {

        public int idunidadmedida { get; set; }
        public int idempresa { get; set; }
        public int idtipomedida { get; set; }
        public string simbolo { get; set; }
        public string medidaconversion { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public int estado1 { get; set; }
		public string tipomedida { get; set; }

        public int codigounico { get; set; }

		public T Clone<T>() where T : Unidadmedida
        {
            return (T)this.MemberwiseClone();
        }
    }
}