using System.Runtime.Serialization;


namespace SIS_Ga2.Entity
{
    [DataContract]
    public class paginaroles
    {
        [DataMember]
        public string NombreOpcion { get; set; }
        [DataMember]
        public int idRol { get; set; }
        [DataMember]
        public int idMenuOpcion { get; set; }
        [DataMember]
        public bool FuncionAll { get; set; }
        [DataMember]
        public bool FuncionBorrar { get; set; }
        [DataMember]
        public bool FuncionActualiza { get; set; }
        [DataMember]
        public bool FuncionIngreso { get; set; }
        [DataMember]
        public bool FuncionLectura { get; set; }
        [DataMember]
        public int idPaginaRol { get; set; }
        [DataMember]
        public int idPagina { get; set; }
        [DataMember]
        public int Estado { get; set; }
    }
}
