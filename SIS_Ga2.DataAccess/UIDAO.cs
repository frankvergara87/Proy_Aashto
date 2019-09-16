using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DbManager.DataObjects;
using SIS_Ga2.Entity;


namespace SIS_Ga2.DataAccess
{
    public class UIDAO
    {

        public List<UI> ListarElementos(UI matriz)
        {
            SqlManager objSql = new SqlManager();
            List<UI> lista = new List<UI>();
            try
            {
                Parameter param = new Parameter();
                param.Add("@idlanguage", matriz.IdUILanguage);
                lista = objSql.getStatement<UI>("usp_uilanguage_reader", param);
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save( 0 ,1 , "Vista", "Listar", ex);
            }
            //Rutina de Guardado en Log 
            return lista;
        }
        public DataTable ListarPivotUI(int idautorizacionusuario)
        {
            SqlManager objSQL = new SqlManager();
            DataTable tbl = new DataTable();
            try
            {
                tbl = objSQL.ExecuteDataTable("usp_listarPivot_UI");
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(idautorizacionusuario, 0, "UI", "Index", ex);
            }
            return tbl;
        }
        public bool RegistrarCodigoElemento(UI objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@ElementCode", objEntidad.ElementCode);
            try
            {
                objSql.ExecuteNonQuery("usp_RegistrarCodigoElementoPivot_UI", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }
        public bool ActualizarElementos(UI objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@ElementCode", objEntidad.ElementCode);
            param.Add("@IdUILanguage", objEntidad.IdUILanguage);
            param.Add("@ElementCaptionText", objEntidad.ElementCaptionText);
            try
            {
                objSql.ExecuteNonQuery("usp_ActualizarCodigoElementoPivot_UI", param);
                resultado = true;
            }
            catch (Exception)
            {
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }

    }
}
