using System;
using System.Collections.Generic;

namespace SIS_Ga2.Entity
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string cuenta { get; set; }
        public string clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public int Aplicacion {get;set;}


        //public DateTime FechaRegistro { get; set; }
        //public List<Sociedades_Logistica> ListaSociedades { get; set; }
        //public Sociedades_Logistica BESociedades_Logistica { get; set; }
        //public string LangName { get; set; }
        //public string codigosociedad { get; set; } 
        //public string Descripcionsociedad { get; set; }
        //public Usuario()
        //{
        //    BookViewModel = new List<BookViewModel>();
        //}
        //public int Id
        //{
        //    get;
        //    set;
        //}
        //public string Name
        //{
        //    get;
        //    set;
        //}
        //public bool IsAuthor
        //{
        //    get;
        //    set;
        //}
        //public IList<BookViewModel> BookViewModel
        //{
        //    get;
        //    set;
        //}
    }
}
