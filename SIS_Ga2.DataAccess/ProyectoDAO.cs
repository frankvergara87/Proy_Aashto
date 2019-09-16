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
    public class ProyectoDAO
    {
        public List<Proyecto> ListarProyectos(int idTipoDiseno, int idUsuario)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idTipoDiseno", idTipoDiseno);
                param.Add("@IdUsuario", idUsuario);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<Proyecto> lista = objSql.getStatement<Proyecto>("USP_ListaProyecto_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

        public int GuardarProyecto(Proyecto DataProyecto)
        {
            int resultado = 0;

            try
            {
                Parameter param = new Parameter();
                param.Add("@CodProyecto", DataProyecto.CodProyecto);
                //param.Add("@IdUsuario", DataProyecto.idUsuario);
                //param.Add("@idReglamento", DataProyecto.idReglamento);
                //param.Add("@idTipoDiseno", DataProyecto.idTipoDiseno);
                //param.Add("@FecProyecto", DataProyecto.FecProyecto);
                //param.Add("@Ubicacion", DataProyecto.Ubicacion);
                //param.Add("@NumDiseno", DataProyecto.NumDiseno);
                //param.Add("@Tramo", DataProyecto.Tramo);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());

                resultado = Convert.ToInt32(objSql.ExecuteNoQuery("USP_InsProyecto", param));
                

            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
            return resultado;
        }
    }
}
