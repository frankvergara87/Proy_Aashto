using System;
using System.Collections.Generic;

namespace SIS_Ga2.Entity
{
    public class rol
    {
        public Int32 idRol { get; set; }
        public String nombre { get; set; }
        public Boolean estado { get; set; }
        public string DescripcionRol { get; set; }
        public string CodigoSociedad { get; set; }
        public string DescripcionSociedad { get; set; }
        public string RUCSociedad { get; set; }
        public int idSociedadLogistica { get; set; }
        public int CodigoRol { get; set; }
        public bool a { get; set; }
        public rol()
        {
            BookViewModel = new List<MenubarOpcion>();
        }
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public bool IsAuthor
        {
            get;
            set;
        }
        public IList<MenubarOpcion> BookViewModel
        {
            get;
            set;
        }
    }
}
