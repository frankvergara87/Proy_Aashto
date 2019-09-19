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
    public class DACTipoDiseno
    {

        public List<BETipoDiseno> ListarTipoDisenoxId(int idReglamento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@IdTipoDiseno", idReglamento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETipoDiseno> lista = objSql.getStatement<BETipoDiseno>("USP_ListarTipoDisenoXId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<BETipoDiseno> ListarTipoDisenos()
        {
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BETipoDiseno> lista = objSql.getStatement<BETipoDiseno>("USP_TipoDisenos_Lst", param);
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
