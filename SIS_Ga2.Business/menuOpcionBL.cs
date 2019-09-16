using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SIS_Ga2.Business
{
    public class menuOpcionBL
    {
        //public static List<MenuOpcion> GetMenuOpciones(Int32 IdRol, Int32 IdLanguage, Int32 IdSistema,string tipoentidad)
        //{
        //    opcionmenuDAO dao = new opcionmenuDAO();
        //    return dao.GetMenuOpciones(IdRol, IdLanguage, IdSistema,tipoentidad);
        //}
        public static List<MenubarOpcion> GetMenubarOpciones(string codigosociedad)
        {
            opcionmenuDAO dao = new opcionmenuDAO();
            List<MenuOpcion> lista = dao.GetMenuOpciones(codigosociedad);

            List<MenubarOpcion> MenuBar = new List<MenubarOpcion>();
            MenuBar.AddRange(lista.FindAll(a => a.idPadre == 0).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = 0, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, MenubarDetalle = new List<MenubarOpcion>() }).ToList());

            for (int i = 0; i < MenuBar.Count; i++) MenuBar[i] = AddDetalleMenubar(MenuBar[i], lista);

            return MenuBar;
        }
        private static MenubarOpcion AddDetalleMenubar(MenubarOpcion padre, List<MenuOpcion> lista)
        {
            padre.MenubarDetalle.AddRange(lista.FindAll(a => a.idPadre == padre.IdMenuOpcion).OrderBy(a => a.Jerarquia).Select(b => new MenubarOpcion() { IdMenuOpcion = b.idMenuOpcion, IdMenuOpcion_Padre = padre.IdMenuOpcion, Jerarquia = b.Jerarquia, NombreOpcion = b.Nombreopcion, RutaRelativa = b.Rutarelativa, Icono = b.icono, MenubarDetalle = new List<MenubarOpcion>() }).ToList());
            for (int i = 0; i < padre.MenubarDetalle.Count; i++) padre.MenubarDetalle[i] = AddDetalleMenubar(padre.MenubarDetalle[i], lista);
            return padre;
        }


        //public List<MenuOpcion> ListaOpciones(MenuOpcion opcion)
        //{
        //    opcionmenuDAO dao = new opcionmenuDAO();
        //    return dao.ListaOpciones(opcion);
        //}
        //public List<MenuOpcion> ListaOpcionesRoles(MenuOpcion opcion)
        //{
        //    opcionmenuDAO dao = new opcionmenuDAO();
        //    return dao.ListaOpcionesRoles(opcion);
        //}
    }
}
