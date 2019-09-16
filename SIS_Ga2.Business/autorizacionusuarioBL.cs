using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.Business
{
    public class autorizacionusuarioBL
    {
        //public static List<String> GetUsuarioAutorizacionCorreos(String TipoEntidad, String CodigoUnico, out List<Int32> Idusuarios)
        //{
        //    try
        //    {
        //        autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //        return objDAO.GetUsuarioAutorizacionCorreos(TipoEntidad, CodigoUnico, out Idusuarios);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<Autorizacionusuario> ListarUsuariosByEntidad(String TipoEntidad, String CodigoUnico)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.ListarUsuariosByEntidad(TipoEntidad, CodigoUnico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Boolean ValidContrasenaAlmacen(Int32 IdUsuario, String Clave)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.ValidContrasenaAlmacen(IdUsuario, Clave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Int32 GetIdUsuarioByCodRepresentante(String CodRepresentante,String tipoentidad)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetIdUsuarioByCodRepresentante(CodRepresentante, tipoentidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Int32 GetEmpresaByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetEmpresaByIdUsuario(idautorizacionusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static String GetTipoEntidadByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetTipoEntidadByIdUsuario(idautorizacionusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static String GetCodigoUnicoByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetCodigoUnicoByIdUsuario(idautorizacionusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static String GetCodRepresentanteByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetCodRepresentanteByIdUsuario(idautorizacionusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Autorizacionusuario GetUsuarioAutorizacion(Int32 idautorizacionusuario)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetUsuarioAutorizacion(idautorizacionusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Autorizacionusuario> GetUsuarioAutorizacionByTipoEntidad(String TipoEntidad)
        {
            try
            {
                autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
                return objDAO.GetUsuarioAutorizacionByTipoEntidad(TipoEntidad);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Autorizacionusuario ObtenerUsuarioPorId(int id)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.ObtenerUsuarioPorId(id);
        }

        public static Autorizacionusuario LoginByCorreo(String Correo)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.LoginByCorreo(Correo);
        }

        public List<Autorizacionusuario> busqueda(string cuenta, string tipoentidad)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.busqueda(cuenta, tipoentidad);
        }

        //public bool registrar(Autorizacionusuario autorizacionusuario)
        //{
        //    autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //    return objDAO.registrar(autorizacionusuario);
        //}


        //public Autorizacionusuario obtener(Autorizacionusuario autorizacionusuario)
        //{
        //    autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //    return objDAO.obtener(autorizacionusuario);

        //}

        //public bool actualizar(Autorizacionusuario autorizacionusuario)
        //{
        //    try
        //    {
        //        autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //        return objDAO.actualizar(autorizacionusuario);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public bool EliminarAutorizacionusuario(int idautorizacionusuario)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.EliminarAutorizacionusuario(idautorizacionusuario);
        }


        public List<rol> ListarRol()
        {
            autorizacionusuarioDAO dao = new autorizacionusuarioDAO();
            return dao.ListarRol();
        }


        public static List<rol> ListarRoles()
        {
            autorizacionusuarioDAO dao = new autorizacionusuarioDAO();
            return dao.ListarRol();
        }

        public List<Autorizacionusuario> ListarCombo()
        {
            autorizacionusuarioDAO dao = new autorizacionusuarioDAO();
            return dao.ListarCombo();
        }

        //public bool recibecorreo(Autorizacionusuario autorizacionusuario, ref string mensaje)
        //{
        //    autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //    return objDAO.recibecorreo(autorizacionusuario, ref mensaje);
        //}

        public List<Unidadmedida> listarentidad(string codigoentidad)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.listarentidad(codigoentidad);
        }

        //public List<Tipofirmante> obtenertipofirmante(string tipoentidad, string codigounico, int idproceso)
        //{
        //    try
        //    {
        //        autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //        return objDAO.obtenerfirmante(tipoentidad, codigounico, idproceso);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Autorizacionusuario validarcorreo(string correo)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.validarcorreo(correo);
        }
        public Autorizacionusuario validarcuenta(string cuenta)
        {
            autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
            return objDAO.validarcuenta(cuenta);
        }


        //public bool actualizar_clave(Autorizacionusuario autorizacion)
        //{
        //    autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //    return objDAO.actualizar_clave(autorizacion);
        //}

        //CAMBIADO POR VICTOR LEMA POR USUARIO.
        //public Usuario login(Usuario objEntidad)
        //{
        //    autorizacionusuarioDAO objDAO = new autorizacionusuarioDAO();
        //    return objDAO.login(objEntidad);
        //}
    }
}
