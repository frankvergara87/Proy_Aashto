using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SIS_Ga2.DataAccess
{
    public class procesorolusuarioDAO
    {
        public List<UsuarioRoles> GetProcesoRolUsuarioByUsuarioId(Int32 IdAutorizacionUsuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                List<UsuarioRoles> objLst = new List<UsuarioRoles>();
                param.Add("@idautorizacionusuario", IdAutorizacionUsuario);
                param.Add("@idSociedadLogistica", 1);
                objLst = objSql.getStatement<UsuarioRoles>("USP_UsuariosRolesByUsuarioPorSociedad_Lst", param);
                return objLst;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "selectbyidprocesorolusuario", "GetProcesoRolUsuarioByUsuarioId", ex);
                throw ex;
            }
        }

        public List<procesorolusuario> obtener_procesorolusuario(int id)
        {

            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            List<procesorolusuario> procesorolusuario = new List<procesorolusuario>();
            param.Add("@idautorizacionusuario", id);
            try
            {
                procesorolusuario = objSql.getStatement<procesorolusuario>("USP_obtener_procesorolusuario", param);
            }
            catch (Exception ex) {
                throw ex;
                //afilogDAO.Save(0, 0, "obtenerprocesorolusuario", "obtener_procesorolusuario", ex);
            }
            //Rutina de Guardado en Log 
            return procesorolusuario;

        }
        public bool registrar(procesorolusuario procesorolusuario)
        {

            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@idempresa", procesorolusuario.idempresa);
            param.Add("@idautorizacionusuario", procesorolusuario.idautorizacionusuario);
            param.Add("@codigounico", procesorolusuario.codigounico);
            param.Add("@tipoentidad", procesorolusuario.Codigo_Sociedad);
            param.Add("@idrol", procesorolusuario.idrol);
            param.Add("@idproceso", procesorolusuario.idproceso);
            param.Add("@estado", procesorolusuario.estado);
            try
            {
                objSql.ExecuteNonQuery("USP_registrar_procesorolusuario", param);
                resultado = true;
            }
            catch (Exception ex) {
                throw ex;
                //afilogDAO.Save(0, 0, "registrarprocesorolusuario", "registrar", ex);
                }
            //Rutina de Guardado en Log 
            return resultado;


        }

        public bool actualizarRolUsuario(procesorolusuario procesorolusuario)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();


            param.Add("@idempresa", procesorolusuario.idempresa);
            param.Add("@idautorizacionusuario", procesorolusuario.idautorizacionusuario);
            param.Add("@codigounico", procesorolusuario.codigounico);
            param.Add("@tipoentidad", procesorolusuario.Codigo_Sociedad);
            param.Add("@idrol", procesorolusuario.idrol);
            param.Add("@idproceso", procesorolusuario.idproceso);
            param.Add("@estado", procesorolusuario.estado);

            try
            {
                objSql.ExecuteNonQuery("USP_actualizar_procesorolusuario", param);
                resultado = true;

            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "actualizarprocesorolusuario", "actualizarRolUsuario", ex);
                throw ex;
            }

            return resultado;
        }

        public bool EliminarAutorizacionProcesoRol(Int32 idautorizacionusuario)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@idautorizacionusuario", idautorizacionusuario);
            try
            {
                objSql.ExecuteNoQuery("USP_eliminar_procesorolusuario",param);
            }
            catch (Exception  ex)
            {
                //afilogDAO.Save(0, 0, "eliminarprocesorolusuario", "EliminarAutorizacionProcesoRol", ex);
                throw  ex;
            }
            return resultado;
        }
    }
}
