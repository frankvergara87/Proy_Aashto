using System;
using System.Collections.Generic;

namespace SIS_Ga2.Entity
{
    public class BEUsuario
    {
        public int idUsuario { get; set; }
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string CIP { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int Estado { get; set; }
        public int idJerarquia { get; set; }
        public int idCargo { get; set; }           
        public double FechaCreacion { get; set; }
        public double HoraCreacion { get; set; }
        public string UsrCreacion { get; set; }        
        public double FechaActualizacion { get; set; }
        public double HoraActualizacion { get; set; }
        public string UsrActualizacion { get; set; }


    }
}
