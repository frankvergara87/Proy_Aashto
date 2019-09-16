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
    public class DisenoDAO
    {
        public List<ParametrosDiseno> ListarParametrosxTipoDiseno(int idTipoDiseno)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTipoDiseno", idTipoDiseno);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<ParametrosDiseno> lista = objSql.getStatement<ParametrosDiseno>("USP_ParametrosDiseno_Lst", param);
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
