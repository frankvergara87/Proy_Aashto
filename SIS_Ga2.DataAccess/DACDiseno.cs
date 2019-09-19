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
    public class DACDiseno
    {
        public List<BEDiseno> ListarDisenoxId(int idDiseno)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idDiseno", idDiseno);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEDiseno> lista = objSql.getStatement<BEDiseno>("USP_ListarDisenosxId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

        public List<BEDiseno> ListarDisenos()
        {


            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEDiseno> lista = objSql.getStatement<BEDiseno>("USP_Disenos_Lst", param);
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
