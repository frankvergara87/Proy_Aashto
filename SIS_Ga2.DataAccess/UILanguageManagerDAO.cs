using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.DataAccess
{
    public class UILanguageManagerDAO
    {
        public String GetLanguageCode(Int32 IdIdioma)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdUILanguage", IdIdioma);

                String CodEmpresa = objSql.ExecuteScalar("USP_UILanguage_SelectLangCode", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<UIElement> ListarElementos(Int32 IdUILanguage)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idlanguage", IdUILanguage);
                SqlManager objSql = new SqlManager();
                List<UIElement> lista = objSql.getStatement<UIElement>("USP_uilanguage_reader", param);

                param = null;
                objSql.Dispose();
                objSql = null;
                return lista;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "UILanguageManagerDAO", "ListarElementos", ex);
                throw ex;
            }
        }

        public List<UILanguage> ListarIdiomas()
        {
            SqlManager objSql = new SqlManager();
            List<UILanguage> lista = new List<UILanguage>();
            Parameter param = new Parameter();
            param.Add("@IdUILanguage", "0");
            try
            {
                lista = objSql.getStatement<UILanguage>("USP_listar_uilanguage", null);

            }
            catch (Exception ex) { throw ex; }
            //Rutina de Guardado en Log 
            return lista;
        }
    }
}
