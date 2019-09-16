using System.Text;
using DbManager.DataObjects;
using System.Configuration;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SIS_Ga2.DataAccess
{
    public class SistemasDAO
    {
        public Usuario login(Usuario objEntidad)
        {
            Usuario logeo = new Usuario();
            List<Usuario> list = new List<Usuario>();
            SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
            Parameter param = new Parameter();
            param.Add("@cuenta", objEntidad.cuenta);
            param.Add("@clave", objEntidad.clave);
            try
            {
                list = objSql.getStatement<Usuario>("SEG_USP_Login", param);
                if (list.Count != 0)
                {
                    logeo = list.First();
                }
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario login", "Login", ex);
                throw new Exception(ex.Message);
            }
            return logeo;
        }
    }
}
