using System;
using System.Collections.Generic;

namespace SIS_Ga2.Entity
{
    public class MenuOpcion
    {
        public int idMenuOpcion { get; set; }
        public int idrol { get; set; }
        public int idsistema { get; set; }
        public int idLanguage { get; set; }
        public int idPadre { get; set; }
        public int Jerarquia { get; set; }
        public int idAplicacion { get; set; }
        public string Nombreopcion { get; set; }
        public string Rutarelativa { get; set; }
        public String icono { get; set; }
        public bool Estado { get; set; }
        public int TieneRol { get; set; }
    }

    public class MenubarOpcion
    {
        public Int32 IdMenuOpcion { get; set; }
        public Int32 IdMenuOpcion_Padre { get; set; }
        public Int32 Jerarquia { get; set; }
        public String NombreOpcion { get; set; }
        public String RutaRelativa { get; set; }
        public String Icono { get; set; }
        public Boolean Estado { get; set; }
        public int TieneRol { get; set; }

        public List<MenubarOpcion> MenubarDetalle { get; set; }
    }
}
