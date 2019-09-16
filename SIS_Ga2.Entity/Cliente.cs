using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SIS_Ga2.Entity
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string CodigoEmpresa { get; set; }
        public int CodigoCliente { get; set; }
        public int CodigoUbigeo { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string DireccionCobranza { get; set; }
        public int IdCatalogo { get; set; }
        public string CatalogoValor { get; set; }
        public string Telefono { get; set; }
        public string Ruc { get; set; }
        public string EstadoRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string ContactoCliente { get; set; }
        public string CodSociedad { get; set; }

    }
}
