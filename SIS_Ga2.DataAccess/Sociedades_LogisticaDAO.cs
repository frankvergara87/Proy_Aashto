using DbManager.DataObjects;
using System;
using System.Collections.Generic;
using SIS_Ga2.Entity;
using System.Configuration;

namespace SIS_Ga2.DataAccess
{
    public class Sociedades_LogisticaDAO
    {
        public List<Sociedades_Logistica> ListarSociedades_Logistica()
        {
            try
            {
                Parameter param = new Parameter();                
                SqlManager objSql = new SqlManager();
                List<Sociedades_Logistica> lista = objSql.getStatement<Sociedades_Logistica>("SEG_Sociedades_Logistica", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

        //public bool Registrar(Sociedades_Logistica objEntidad)
        //{
        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();
        //    param.Add("@Codigo_Sociedad", objEntidad.Codigo_Sociedad );
        //    param.Add("@Descripcion_Sociedad", objEntidad.Descripcion_Sociedad );
        //    param.Add("@Numero_RUC_Sociedad", objEntidad.Numero_RUC_Sociedad);
        //    try
        //    {
        //        objSql.ExecuteNonQuery("USP_Sociedades_Logistica_Ins", param);
        //        resultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Sincronizar cliente", "registrar", ex);
        //        resultado = false;
        //    }
        //    //Rutina de Guardado en Log 
        //    return resultado;
        //}

        //public bool Actualizar(Sociedades_Logistica objEntidad)
        //{
        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();
        //    param.Add("@Codigo_Sociedad", objEntidad.Codigo_Sociedad);
        //    param.Add("@Descripcion_Sociedad", objEntidad.Descripcion_Sociedad);
        //    param.Add("@Numero_RUC_Sociedad", objEntidad.Numero_RUC_Sociedad);
        //    try
        //    {
        //        objSql.ExecuteNonQuery("USP_Sociedades_Logistica_Upd", param);
        //        resultado = true;
        //    }
        //    catch (Exception)
        //    {
        //        //afilogDAO.Save(0, 0, "Sincronizar cliente", "registrar", ex);
        //        resultado = false;
        //    }
        //    //Rutina de Guardado en Log 
        //    return resultado;
        //}

        public List<Sociedades_Logistica> ListarSociedades_Logistica_PorUsuario(int IdAutorizacionUsuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdAutorizacionUsuario", IdAutorizacionUsuario);
                List<Sociedades_Logistica> lista = objSql.getStatement<Sociedades_Logistica>("USP_SociedadesPorUsuario_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
