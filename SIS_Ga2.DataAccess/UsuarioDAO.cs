using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.DataAccess
{
    public  class UsuarioDAO
    {
        public bool Registrar(Cliente objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@CodigoEmpresa", objEntidad.CodigoEmpresa);
            param.Add("@CodigoCliente", objEntidad.CodigoCliente);
            param.Add("@CodigoUbigeo", objEntidad.CodigoUbigeo);
            param.Add("@RazonSocial", objEntidad.RazonSocial);
            param.Add("@Direccion", objEntidad.Direccion);
            param.Add("@DireccionCobranza", objEntidad.DireccionCobranza);
            param.Add("@IdCatalogo", objEntidad.IdCatalogo);
            param.Add("@Telefono", objEntidad.Telefono);
            param.Add("@Ruc", objEntidad.Ruc);
            param.Add("@EstadoRegistro", objEntidad.EstadoRegistro);
            param.Add("@TipoDocumento", objEntidad.TipoDocumento);
            param.Add("@ContactoCliente", objEntidad.ContactoCliente);
            param.Add("@CodSociedad", objEntidad.CodSociedad);

            try
            {
                objSql.ExecuteNonQuery("USP_Registrar_Cliente", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Sincronizar cliente", "registrar", ex);
                resultado = false;
            }
            //Rutina de Guardado en Log 
            return resultado;
        }

        public bool Actualizar(Cliente objEntidad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@IdCliente", objEntidad.IdCliente);
            param.Add("@CodigoEmpresa", objEntidad.CodigoEmpresa);
            param.Add("@CodigoCliente", objEntidad.CodigoCliente);
            param.Add("@CodigoUbigeo", objEntidad.CodigoUbigeo);
            param.Add("@RazonSocial", objEntidad.RazonSocial);
            param.Add("@Direccion", objEntidad.Direccion);
            param.Add("@DireccionCobranza", objEntidad.DireccionCobranza);
            param.Add("@IdCatalogo", objEntidad.IdCatalogo);
            param.Add("@Telefono", objEntidad.Telefono);
            param.Add("@Ruc", objEntidad.Ruc);
            param.Add("@EstadoRegistro", objEntidad.EstadoRegistro);
            param.Add("@TipoDocumento", objEntidad.TipoDocumento);
            param.Add("@ContactoCliente", objEntidad.ContactoCliente);
            param.Add("@CodSociedad", objEntidad.CodSociedad);

            try
            {
                objSql.ExecuteNonQuery("USP_Actualizar_Cliente", param);
                resultado = true;
            }
            catch (Exception)
            {
                 resultado = false;
            }            
            return resultado;
        }

        public List<Cliente> ListarClienteByID(int IdCliente)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@IdCliente", IdCliente);
                SqlManager objSql = new SqlManager();
                List<Cliente> lista = objSql.getStatement<Cliente>("USP_ListaCliente_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario> ListarUsuario()
        {
            try
            {
                Parameter param = new Parameter();                
                SqlManager objSql = new SqlManager();

                List<Usuario> lista = objSql.getStatement<Usuario>("SEG_USP_Usuarios_Lst", param);
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
            param.Add("@cuenta",usuario.cuenta);
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
        public List<rol> ListarRolesPorSociedad(int idsociedad,int idusuario)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@idsociedad", idsociedad);
                param.Add("@idusuario", idusuario);
                SqlManager objSql = new SqlManager();
                List<rol> listadoroles = objSql.getStatement<rol>("SEG_USP_RolesPorSociedad_Lst", param);
                return listadoroles;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AgregarRol(int idusuario, int idsociedad, int idrol)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@idusuario", idusuario);
            param.Add("@idsociedad", idsociedad);
            param.Add("@idrol", idrol);
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Agr_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;
        }
        public bool  DeleteRolUsuario(int idusuario, int idsociedad)
        {
            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();
            param.Add("@idusuario", idusuario);
            param.Add("@idsociedad", idsociedad);            
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Agr_Del", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return resultado;
        }
        //public List<Aplicacion> AplicacionesPorusuario(int idusuario)
        //{
        //    try
        //    {
        //        List<Aplicacion> aplicaciones = new List<Aplicacion>();
        //        Parameter param = new Parameter();
        //        param.Add("@idusuario", idusuario);
        //        SqlManager objSql = new SqlManager();
        //        List<rol> roles = objSql.getStatement<rol>("SEG_USP_RolesPorUsuario_Lst", param);
        //        foreach (rol rol in roles)
        //        {

        //        }
        //       // return aplicaciones;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
