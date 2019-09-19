using DbManager.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;

namespace SIS_Ga2.DataAccess
{
    public class DACProvincia
    {
        public List<BEProvincia> ListarProvinciaXID(int idProvincia)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idProvincia", idProvincia);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEProvincia> lista = objSql.getStatement<BEProvincia>("USP_ListarProvinciaXId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

        public List<BEProvincia> ListarProviciaXDep(int idDepartamento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idDepartamento", idDepartamento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEProvincia> lista = objSql.getStatement<BEProvincia>("USP_ListarProviciaXDep_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }


    }
}
