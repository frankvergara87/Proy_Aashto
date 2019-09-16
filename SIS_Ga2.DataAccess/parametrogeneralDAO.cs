using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SIS_Ga2.DataAccess
{
    public class parametrogeneralDAO
    {
        public parametrogeneral GetParametroGeneral(Int32 idparametrogeneral)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idparametrogeneral", idparametrogeneral);

                List<parametrogeneral> lista = objSql.getStatement<parametrogeneral>("USP_ParametroGeneral_SelectByKey", param);

                if (lista != null && lista.Count > 0) return lista[0];
                else return new parametrogeneral();
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "parametrogeneral selectbykey", "GetParametroGeneral", ex);
            }
            //Rutina de Guardado en Log 
            return new parametrogeneral();
        }

        public parametrogeneral GetParametroGeneralByEmpresaId(string codigosociedad)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@codigosociedad", codigosociedad);

                List<parametrogeneral> lista = objSql.getStatement<parametrogeneral>("SEG_USP_ParamatroGeneral_por_codigosociedad", param);

                if (lista != null && lista.Count > 0) return lista[0];
                else return new parametrogeneral();
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "parametrogeneral SelectByEmpresaId", "GetParametroGeneralByEmpresaId", ex);
            }
            //Rutina de Guardado en Log 
            return new parametrogeneral();
        }

        public parametrogeneral GetParametroGeneralByIdSociedadLogistica(int idSociedadLogistica)
        {
            try
            {
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["BDSEGURIDAD"].ToString());
                Parameter param = new Parameter();
                param.Add("@idSociedadLogistica", idSociedadLogistica);
                List<parametrogeneral> lista = objSql.getStatement<parametrogeneral>("USP_ParametroGeneral_SelectByCodigo_Sociedad", param);
                if (lista != null && lista.Count > 0) return lista[0];
                else return new parametrogeneral();
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "parametrogeneral SelectByEmpresaId", "GetParametroGeneralByEmpresaId", ex);
            }
            //Rutina de Guardado en Log 
            return new parametrogeneral();
        }


        public bool Save(parametrogeneral entity)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();

                param.Add("@idparametrogeneral", entity.idparametrogeneral);
                //param.Add("@idempresa", entity.idempresa);
                param.Add("@rutapdf", entity.rutapdf);
                param.Add("@rutafirma", entity.rutafirma == null ? String.Empty : entity.rutafirma.ToString());
                param.Add("@color", entity.color);
                param.Add("@rutalogo", entity.rutalogo);
                param.Add("@tipoletra", entity.tipoletra);

                objSql.ExecuteNonQuery("USP_ParametroGeneral_Save", param);

                return true;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "parametrogeneral Save", "Save", ex);
                return false;
            }
        }
    }
}
