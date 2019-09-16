using System;
using SIS_Ga2.Entity;
using DbManager.DataObjects;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.DataAccess
{
    public class GenericDAO
    {
        public List<TipoDisenos> ExtraerTipoDiseno(int idTipoDiseno)
        {
            SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
            List<TipoDisenos> lista = new List<TipoDisenos>();
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTipoDiseno", idTipoDiseno);

                lista = objSql.getStatement<TipoDisenos>("USP_TipoDiseno_lst", param);
                if (lista.Count != 0)
                {
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }

        public List<Reglamentos> ExtraerReglamento(int idReglamento)
        {
            SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
            List<Reglamentos> lista = new List<Reglamentos>();
            try
            {
                Parameter param = new Parameter();
                param.Add("@idReglamento", idReglamento);

                lista = objSql.getStatement<Reglamentos>("USP_Reglamento_lst", param);
                if (lista.Count != 0)
                {
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }

        public List<Periodo> ExtraerPeriodos()
        {
            SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
            List<Periodo> lista = objSql.getStatement<Periodo>("USP_Periodos_Lst");
            return lista;

        }


    }
}
