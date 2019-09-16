using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SIS_Ga2.Entity
{
    [DataContract]
    public class Autorizacionusuario
    {
        public int idUsuario { get; set; }
        public string Cuenta { get; set; }
        public string contrasena { get; set; }
        public int IdAplicacion { get; set; }

        //[DataMember]
        //public string CodigoSociedad { get; set; }

        //public Sociedades_Logistica BESOCIEDAD { get; set; }


    }

}
