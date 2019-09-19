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
    public class DACPeriodo
    {
        public List<BEPeriodo> ListarPeriodos(int idPeriodo)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idPeriodo", idPeriodo);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEPeriodo> lista = objSql.getStatement<BEPeriodo>("[USP_Sel_Periodos]", param);
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
