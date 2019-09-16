using System;

namespace SIS_Ga2.Entity
{
    public class UsuarioRoles
    {
        public int idUsuarioRoles { get; set; }
        public int idSociedadesUsuario { get; set; }
        public int idRol { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
