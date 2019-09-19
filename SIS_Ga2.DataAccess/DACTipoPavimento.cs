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
    public class DACTipoPavimento
    {

        public List<BETipoPavimento> ListarTipoPavimento(int idTipoPavimento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTipoPavimento", idTipoPavimento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETipoPavimento> lista = objSql.getStatement<BETipoPavimento>("[USP_Sel_TipoPavimento]", param);
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
