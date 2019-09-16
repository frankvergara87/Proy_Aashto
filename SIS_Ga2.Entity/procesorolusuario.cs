using System.Runtime.Serialization;


namespace SIS_Ga2.Entity
{
    [DataContract]
    public class procesorolusuario
    {
        [DataMember]
        public int idusuariorolproceso { get; set; }
        [DataMember]
        public int idempresa { get; set; }
        [DataMember]
        public int idautorizacionusuario { get; set; }
        [DataMember]
        public string codigounico { get; set; }
        [DataMember]
        public string Codigo_Sociedad { get; set; }
        [DataMember]
        public int idrol { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int idproceso { get; set; }
        [DataMember]
        public bool estado { get; set; }

    }
}
