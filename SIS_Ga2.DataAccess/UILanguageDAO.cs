using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using DbManager.DataObjects;

namespace SIS_Ga2.DataAccess
{
    public class UILanguageDAO
    {

        public List<UILanguage> ListarIdiomas(UILanguage objEntidad)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            List<UILanguage> lista = new List<UILanguage>();
            param.Add("@IdUILanguage", objEntidad.IdUILanguage);

            try
            {
                lista = objSql.getStatement<UILanguage>("USP_listar_uilanguage", param);
            }
            catch (Exception ex) {
                throw ex;
                //afilogDAO.Save(0, 0, "UILanguageDAO", "ListarIdiomas", ex);
            }
            //Rutina de Guardado en Log 
            return lista;
        }


        public UILanguage ObtenerIdioma(UILanguage objEntidad)
        {

            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            UILanguage obj = null;
            param.Add("@IdUILanguage", objEntidad.IdUILanguage);
            try
            {
                obj = objSql.getStatement<UILanguage>("USP_listar_uilanguage", param)[0];
            }
            catch (Exception ex) {
                //afilogDAO.Save(0, 0, "UILanguageDAO", "ObtenerIdioma", ex);
            }
            //Rutina de Guardado en Log 
            return obj;
        }

        public UILanguage ObtenerNroOrdenMaximo()
        {
            SqlManager objSql = new SqlManager();
            UILanguage obj = null;
            try
            {
                obj = objSql.getStatement<UILanguage>("USP_NroOrdenMaximo_UILanguage")[0];
            }
            catch (Exception ex) {
                //afilogDAO.Save(0, 0, "UILanguageDAO", "ObtenerNroOrdenMaximo", ex);
            }
            //Rutina de Guardado en Log 
            return obj;
        }



        public bool RegistrarIdiomas(UILanguage objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@LangCode", objEntidad.LangCode);
            param.Add("@LangName", objEntidad.LangName);
            param.Add("@Comments", objEntidad.Comments);
            param.Add("@NroOrden", objEntidad.NroOrden);
            try
            {
                string codigo = objSql.ExecuteScalar("USP_registrar_UILanguage", param);
                if (codigo == "1")
                    resultado = true;
                else
                    resultado = false;

            }
            catch (Exception ex) {
                //afilogDAO.Save(0, 0, "UILanguageDAO", "RegistrarIdiomas", ex);
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }


        public bool ActualizarIdiomas(UILanguage objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@IdUILanguage", objEntidad.IdUILanguage);
            param.Add("@LangCode", objEntidad.LangCode);
            param.Add("@LangName", objEntidad.LangName);
            param.Add("@Comments", objEntidad.Comments);
            param.Add("@NroOrden", objEntidad.NroOrden);
            try
            {
                string  codigo = objSql.ExecuteScalar("USP_actualizar_UILanguage", param);
                if (codigo == "1")
                    resultado = true;
                else
                    resultado = false;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "UILanguageDAO", "ActualizarIdiomas", ex);
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }

        public bool EliminarIdiomas(UILanguage objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@IdUILanguage", objEntidad.IdUILanguage);
            try
            {
                objSql.ExecuteNonQuery("USP_desactivar_UILanguage", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "UILanguageDAO", "EliminarIdiomas", ex);
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }


    }
}
