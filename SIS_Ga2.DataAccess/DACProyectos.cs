﻿using DbManager.DataObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;

namespace SIS_Ga2.DataAccess
{
    public class DACProyectos
    {

        public List<BEProyecto> ListarProyectosxId(int idProyecto)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idProyecto", idProyecto);
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEProyecto> lista = objSql.getStatement<BEProyecto>("USP_ListarProyectosXId_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }

        public List<BEProyecto> ListarProyectos()
        {
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                List<BEProyecto> lista = objSql.getStatement<BEProyecto>("USP_Proyectos_Lst", param);
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
