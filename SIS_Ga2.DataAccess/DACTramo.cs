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
    public class DACTramo
    {

        public List<BETramo> ListarTramoxId(int idTramo)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTramo", idTramo);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETramo> lista = objSql.getStatement<BETramo>("USP_ListarTramoXId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BETramo> ListarTramos()
        {
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETramo> lista = objSql.getStatement<BETramo>("USP_Tramos_Lst", param);
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
