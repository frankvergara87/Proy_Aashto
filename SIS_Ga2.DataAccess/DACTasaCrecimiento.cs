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
    public class DACTasaCrecimiento
    {
        public List<BETasaCrecimiento> ListarTasaCrecimiento(int idTasaCrecimiento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTasaCrecimiento", idTasaCrecimiento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETasaCrecimiento> lista = objSql.getStatement<BETasaCrecimiento>("[USP_Sel_TasaCrecimiento]", param);
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
