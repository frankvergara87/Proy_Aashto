using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using DbManager.DataObjects;
using System.Configuration;

namespace SIS_Ga2.DataAccess
{
    public class DACDepartamento
    {
        public List<BeDepartamento> ListarDepartamentos()
        {

      
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BeDepartamento> lista = objSql.getStatement<BeDepartamento>("USP_Departamento_Lst", param);
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

        public List<BeDepartamento> ListarDepartamentoXID(int idDepartamento)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idDepartamento", idDepartamento);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BeDepartamento> lista = objSql.getStatement<BeDepartamento>("USP_ListarDepartamentoXId_Lst", param);
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
