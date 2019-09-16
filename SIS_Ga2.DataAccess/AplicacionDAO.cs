using System;
using System.Collections.Generic;
using SIS_Ga2.Entity;
using DbManager.DataObjects;
using System.Configuration;

namespace SIS_Ga2.DataAccess
{
    public class AplicacionDAO
    {
        public List<Aplicacion> ListarAplicaciones()
        {
            try
            {
                SqlManager objSql = new SqlManager(ConfigurationManager.AppSettings["ASOCEM"].ToString());
                Parameter param = new Parameter();
                List<Aplicacion> lista = objSql.getStatement<Aplicacion>("USP_Aplicacion_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }
        public List<Aplicacion> ListarAplicacion()
        {
            try
            {
                Parameter param = new Parameter();
                SqlManager objSql = new SqlManager();

                List<Aplicacion> lista = objSql.getStatement<Aplicacion>("SEG_USP_Aplicacion_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool RegistroUsuario(Usuario usuario)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@cuenta", usuario.cuenta);
            param.Add("@clave", usuario.clave);
            param.Add("@nombre", usuario.Nombre);
            param.Add("@apellidos", usuario.Apellido);
            param.Add("@dni", usuario.DNI);
            param.Add("@celular", usuario.Celular);
            param.Add("@cargo", usuario.Cargo);
            param.Add("@correo", usuario.Correo);
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Usuarios_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;               
            }
            return resultado;
        }
        public Usuario EditarUsuario(int idusuario)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idusuario", idusuario);
                SqlManager objSql = new SqlManager();
                Usuario usuario = objSql.getStatement<Usuario>("SEG_USP_UsuariosPorUsuario_Lst", param)[0];
                return usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ActualizarUsuario(Usuario usuario)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@cuenta", usuario.cuenta);
            param.Add("@clave", usuario.clave);
            param.Add("@nombre", usuario.Nombre);
            param.Add("@apellidos", usuario.Apellido);
            param.Add("@dni", usuario.DNI);
            param.Add("@celular", usuario.Celular);
            param.Add("@cargo", usuario.Cargo);
            param.Add("@correo", usuario.Correo);
            param.Add("@idusuario", usuario.idUsuario);
            param.Add("@estado", usuario.Estado);
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Usuarios_Upd", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            return resultado;
        }
        public bool RegistrarAplicacion(Aplicacion aplicacion)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@color", aplicacion.ColorBoton);
            param.Add("@imagenurl", aplicacion.ImagenUrl);
            param.Add("@nombre", aplicacion.NombreAplicacion);

            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Aplicaciones_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;              
            }
            return resultado;
        }
    }

}
