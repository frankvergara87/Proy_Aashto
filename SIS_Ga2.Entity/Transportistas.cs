using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.Entity
{
    public class Transportistas
    {
        public string Codigo_Sociedad { get; set; }
        public string RUC_Transportista { get; set; }
        public string Nombre_Transportista { get; set; }
        public string Direccion_Transportista { get; set; }
        public string Telefono_Transportista { get; set; }      
        public string Tipo_Empresa_P_T { get; set; }
        public int numerador { get; set; }
        public string estado {get; set;}
        public bool estado_modificar { get; set; }
    }
}
