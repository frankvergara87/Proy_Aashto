using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.DataAccess
{
    public class opcionmenuDAO
    {
        public List<MenuOpcion> GetMenuOpciones(string codigosociedad)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@codigosociedad", codigosociedad);
                List<MenuOpcion> objLista = objSql.getStatement<MenuOpcion>("SEG_USP_MenuOpcion");
                param = null;
                objSql.Dispose();
                objSql = null;
                return objLista;
            }
            catch (Exception ex)
            {
               //afilogDAO.Save(0, 0, "opcionmenuDAO", "GetMenuOpciones", ex);
                throw ex;
            }
        }

        public List<MenuOpcion> ListaOpciones(MenuOpcion opcion)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            List<MenuOpcion> objLista = new List<MenuOpcion>();

            param.Add("@idpadre", opcion.idPadre);
            param.Add("@idsistema", opcion.idsistema);
            param.Add("@idlanguage", opcion.idLanguage);
            try
            {
                objLista = objSql.getStatement<MenuOpcion>("USP_obtener_menu", param);

            }
            catch (Exception ex) {
                //afilogDAO.Save(0, 0, "opcionmenuDAO", "ListaOpciones", ex);
                throw ex;
            }
            //Rutina de Guardado en Log 
            return objLista;
        }

        public List<MenuOpcion> ListaOpcionesRoles(MenuOpcion opcion)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            List<MenuOpcion> objLista = new List<MenuOpcion>();

            param.Add("@idpadre", opcion.idPadre);
            param.Add("@idsistema", opcion.idsistema);
            param.Add("@idlanguage", opcion.idLanguage);
            param.Add("@idrol", opcion.idrol);
            try
            {
                objLista = objSql.getStatement<MenuOpcion>("USP_obtener_menu_roles", param);

            }
            catch (Exception ex) {
                throw ex;
                //afilogDAO.Save(0, 0, "opcionmenuDAO", "ListaOpcionesRoles", ex);
            }
            //Rutina de Guardado en Log 
            return objLista;
        }
    }
}
