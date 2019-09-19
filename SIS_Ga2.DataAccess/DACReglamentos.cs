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
    public class DACReglamentos
    {

        public List<BEReglamentos> ListarReglamentosxId(int idReglamento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idReglamento", idReglamento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEReglamentos> lista = objSql.getStatement<BEReglamentos>("USP_ListarReglamentosXId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<BEReglamentos> ListarReglamentos()
        {
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEReglamentos> lista = objSql.getStatement<BEReglamentos>("USP_Reglamentos_Lst", param);
                param = null;
                objSql.Dispose();
                objSql = null;
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
