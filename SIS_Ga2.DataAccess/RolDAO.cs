using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
namespace SIS_Ga2.DataAccess
{
    public class RolDAO : BaseDAO
    {
        public List<Autorizacionusuario> ListarUsuariosByEntidad(String TipoEntidad, String CodigoUnico)
        {

            try
            {
                Parameter param = new Parameter();
                param.Add("@tipoentidad", TipoEntidad);
                param.Add("@codigounico", CodigoUnico);

                SqlManager objSql = new SqlManager();
                List<Autorizacionusuario> lista = objSql.getStatement<Autorizacionusuario>("up_AutorizacionUsuario_SelectByCodigoUnico", param);

                param = null;
                objSql.Dispose();
                objSql = null;

                return lista;
            }
            catch (Exception ex)
            {

                //afilogDAO.Save(0, 0, "Autorizacionusuario codigounico", "GetUsuarioAutorizacionCorreos", ex);
                throw ex;
            }
        }


        //public List<String> GetUsuarioAutorizacionCorreos(String TipoEntidad, String CodigoUnico, out List<Int32> Idusuarios)
        //{
        //    try
        //    {
        //        Parameter param = new Parameter();
        //        param.Add("@tipoentidad", TipoEntidad);
        //        param.Add("@codigounico", CodigoUnico);

        //        SqlManager objSql = new SqlManager();
        //        List<Autorizacionusuario> lista = objSql.getStatement<Autorizacionusuario>("up_AutorizacionUsuario_SelectCorreosByCodigoUnico", param);

        //        param = null;
        //        objSql.Dispose();
        //        objSql = null;

        //        Idusuarios = lista.Select(a => a.idautorizacionusuario).ToList();
        //        return lista.Select(a => a.correo).ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario codigo representante", "GetIdUsuarioByCodRepresentante", ex);
        //        throw ex;
        //    }
        //}

        public Int32 GetIdUsuarioByCodRepresentante(String CodRepresentante, String tipoentidad)
        {
            Int32 idautorizacionusuario = 0;
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@CodRepresentante", CodRepresentante);
                param.Add("@tipoentidad", tipoentidad);

                String valor = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectIdByCodRepresentante", param);

                param = null;
                objSql.Dispose();
                objSql = null;

                Int32.TryParse(valor, out idautorizacionusuario);
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario validar clave", "ValidContrasenaAlmacen", ex);
                throw ex;
            }
            return idautorizacionusuario;
        }

        public Boolean ValidContrasenaAlmacen(Int32 IdUsuario, String Clave)
        {
            Autorizacionusuario logeo = new Autorizacionusuario();
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@idautorizacionusuario", IdUsuario);
            param.Add("@ContrasenaFirma", Clave);
            try
            {
                List<Autorizacionusuario> list = objSql.getStatement<Autorizacionusuario>("USP_UsuarioAutorizacion_ValidClaveFirma", param);
                return (list != null && list.Count > 0);
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario select empresa", "GetEmpresaByIdUsuario", ex);
                throw new Exception(ex.Message);
            }
        }


        public Int32 GetEmpresaByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                String EmpresaId = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectEmpresa", param).ToString();
                objSql.Dispose();
                param = null;

                return Convert.ToInt32(EmpresaId);
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario SelectTipoEntidad", "GetTipoEntidadByIdUsuario", ex);
                throw ex;
            }
        }
        public String GetTipoEntidadByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                String TipoEntidad = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectTipoEntidad", param).ToString();
                objSql.Dispose();
                param = null;

                return TipoEntidad;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario SelectCodigoUnico", "GetCodigoUnicoByIdUsuario", ex);
                throw ex;
            }
        }
        public String GetCodigoUnicoByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                String CodigoUnico = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectCodigoUnico", param).ToString();
                objSql.Dispose();
                param = null;

                return CodigoUnico;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario SelectCodRepresentante", "GetCodRepresentanteByIdUsuario", ex);
                throw ex;
            }
        }
        public String GetCodRepresentanteByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                String CodRepre = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectCodRepresentante", param).ToString();
                objSql.Dispose();
                param = null;

                return CodRepre;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario SelectCuenta", "GetCuentaByIdUsuario", ex);
                throw ex;
            }
        }
        public String GetCuentaByIdUsuario(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                String CodRepre = objSql.ExecuteScalar("USP_AutorizacionUsuario_SelectCuenta", param).ToString();
                objSql.Dispose();
                param = null;

                return CodRepre;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "obtener Autorizacionusuario", "GetUsuarioAutorizacion", ex);
                throw ex;
            }
        }

        public Autorizacionusuario GetUsuarioAutorizacion(Int32 idautorizacionusuario)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                List<Autorizacionusuario> lista = new List<Autorizacionusuario>();
                param.Add("@idautorizacionusuario", idautorizacionusuario);

                lista = objSql.getStatement<Autorizacionusuario>("USP_obtener_autorizacionusuario", param);
                if (lista == null || lista.Count == 0) return new Autorizacionusuario();
                return lista[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Autorizacionusuario> GetUsuarioAutorizacionByTipoEntidad(String TipoEntidad)
        {
            try
            {
                Parameter param = new Parameter();
                param.Add("@TipoEntidad", TipoEntidad);

                SqlManager objSql = new SqlManager();
                List<Autorizacionusuario> lista = objSql.getStatement<Autorizacionusuario>("up_AutorizacionUsuario_SelectByTipoEntidad", param);

                objSql.Dispose();
                objSql = null;

                param = null;

                return lista;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario selectTipoentidad", "GetUsuarioAutorizacionByTipoEntidad", ex);
                throw ex;
            }
        }


        public Autorizacionusuario ObtenerUsuarioPorId(int id)
        {

            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            Autorizacionusuario objEntidad = new Autorizacionusuario();

            param.Add("@idautorizacionusuario", id);
            try
            {
                objEntidad = objSql.getStatement<Autorizacionusuario>("USP_obtener_autorizacionusuario", param)[0];

            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario ObtenerUsuarioPorId", "ObtenerUsuarioPorId", ex);
            }
            //Rutina de Guardado en Log 
            return objEntidad;

        }

        public Autorizacionusuario LoginByCorreo(String Correo)
        {
            try
            {
                Autorizacionusuario logeo = new Autorizacionusuario();
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@Correo", Correo);

                List<Autorizacionusuario> list = objSql.getStatement<Autorizacionusuario>("USP_Usuario_LoginByCorreo", param);
                if (list.Count > 0) logeo = list.First();
                return logeo;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario login", "LoginByCorreo", ex);
                throw new Exception(ex.Message);
            }
        }

        public Autorizacionusuario login(Autorizacionusuario objEntidad)
        {
            Autorizacionusuario logeo = new Autorizacionusuario();
            List<Autorizacionusuario> list = new List<Autorizacionusuario>();
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@cuenta", objEntidad.Cuenta);
            param.Add("@clave", objEntidad.contrasena);
            try
            {
                list = objSql.getStatement<Autorizacionusuario>("SEG_USP_Login", param);
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

        public List<Autorizacionusuario> busqueda(string cuenta, string tipoentidad)
        {
            List<Autorizacionusuario> autorizacionusuario = new List<Autorizacionusuario>();
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@cuenta", cuenta == null ? String.Empty : cuenta.ToString());
            param.Add("@tipoentidad", tipoentidad == null ? String.Empty : tipoentidad.ToString());

            try
            {
                autorizacionusuario = objSql.getStatement<Autorizacionusuario>("USP_warrants_listar_autorizacionusuario", param);

            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario listar", "busqueda", ex);
                throw new Exception(ex.Message);
            }
            //lista autorizacionusuario
            return autorizacionusuario;

        }

        //public bool registrar(Autorizacionusuario autorizacionusuario)
        //{

        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();


        //    param.Add("@idautorizacionusuario", autorizacionusuario.idautorizacionusuario);
        //    param.Add("@cuenta", autorizacionusuario.cuenta);
        //    param.Add("@clave", autorizacionusuario.clave);
        //    param.Add("@Nombre", autorizacionusuario.nombre);
        //    param.Add("@cargo", autorizacionusuario.cargo);
        //    param.Add("@recibecorreo", autorizacionusuario.recibecorreo);
        //    param.Add("@correo", autorizacionusuario.correo);
        //    param.Add("@codigounico", autorizacionusuario.codigounico == null ? String.Empty : autorizacionusuario.codigounico.ToString());
        //    param.Add("@tipoentidad", autorizacionusuario.tipoentidad);
        //    param.Add("@idempresa", autorizacionusuario.idempresa);
        //    param.Add("@TokenAzure", autorizacionusuario.TokenAzure == null ? String.Empty : autorizacionusuario.TokenAzure.ToString());
        //    param.Add("@idlanguage", autorizacionusuario.idlanguage);
        //    param.Add("@firma", autorizacionusuario.firma);
        //    param.Add("@representante", autorizacionusuario.codigorepresentante);

        //    try
        //    {
        //        autorizacionusuario.idautorizacionusuario = Convert.ToInt32(objSql.ExecuteScalar("USP_registrar_autorizacionusuario", param));

        //        foreach (var item in autorizacionusuario.procesosUsuario)
        //        {
        //            item.idempresa = autorizacionusuario.idempresa;
        //            item.codigounico = autorizacionusuario.codigounico;
        //            item.tipoentidad = autorizacionusuario.tipoentidad;
        //            item.estado = true;
        //            item.idautorizacionusuario = autorizacionusuario.idautorizacionusuario;

        //            procesorolusuarioDAO proceso = new procesorolusuarioDAO();
        //            proceso.registrar(item);

        //            if (autorizacionusuario.firma != "0" & item.idproceso == 1)
        //            {
        //                AutorizacionFirmante lista = new AutorizacionFirmante();
        //                AutorizacionFirmanteDAO autoriza = new AutorizacionFirmanteDAO();
        //                lista.idempresa = autorizacionusuario.idempresa;
        //                lista.tipoentidad = autorizacionusuario.tipoentidad;
        //                lista.autorizacionusuario = Convert.ToString(autorizacionusuario.idautorizacionusuario);
        //                lista.codigounico = autorizacionusuario.codigounico;

        //                if (autorizacionusuario.TipoFirmanteWarrant != 0)
        //                {
        //                    lista.idproceso = 1;
        //                    lista.idtipofirmante = autorizacionusuario.TipoFirmanteWarrant;
        //                    autoriza.RegistarAutorizacionfirmante(lista);
        //                }
        //                if (autorizacionusuario.idTipoFirmanteLIBERACIONES != 0)
        //                {
        //                    lista.idproceso = 2;
        //                    lista.idtipofirmante = autorizacionusuario.idTipoFirmanteLIBERACIONES;
        //                    autoriza.RegistarAutorizacionfirmante(lista);
        //                }
        //                if (autorizacionusuario.idTipoFirmantePRORROGAS != 0)
        //                {
        //                    lista.idproceso = 3;
        //                    lista.idtipofirmante = autorizacionusuario.idTipoFirmantePRORROGAS;
        //                    autoriza.RegistarAutorizacionfirmante(lista);
        //                }




        //            }
        //        }

        //        resultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario registrar", "registrar", ex);
        //        resultado = false;
        //    }
        //    //Rutina de Guardado en Log 
        //    return resultado;

        //}

        //public Autorizacionusuario obtener(Autorizacionusuario autorizacionusuario)
        //{

        //    SqlManager objSql = new SqlManager();
        //    Parameter param = new Parameter();

        //    param.Add("@idautorizacionusuario", autorizacionusuario.idAutorizacionusuario);
        //    try
        //    {
        //        autorizacionusuario = objSql.getStatement<Autorizacionusuario>("USP_obtener_autorizacionusuario", param)[0];

        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario obtener", "obtener", ex);
        //    }
        //    //Rutina de Guardado en Log 
        //    return autorizacionusuario;

        //}

        //public bool actualizar(Autorizacionusuario autorizacionusuario)
        //{
        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();


        //    param.Add("@idautorizacionusuario", autorizacionusuario.idautorizacionusuario);
        //    param.Add("@cuenta", autorizacionusuario.cuenta);
        //    //param.Add("@clave", autorizacionusuario.clave);
        //    param.Add("@Nombre", autorizacionusuario.nombre);
        //    param.Add("@cargo", autorizacionusuario.cargo);
        //    param.Add("@correo", autorizacionusuario.correo);
        //    param.Add("@codigounico", autorizacionusuario.codigounico == null ? String.Empty : autorizacionusuario.codigounico.ToString());
        //    param.Add("@tipoentidad", autorizacionusuario.tipoentidad);
        //    param.Add("@idempresa", autorizacionusuario.idempresa);
        //    param.Add("@TokenAzure", autorizacionusuario.TokenAzure == null ? String.Empty : autorizacionusuario.TokenAzure.ToString());
        //    param.Add("@estado", autorizacionusuario.estado);
        //    param.Add("@idlanguage", autorizacionusuario.idlanguage);
        //    param.Add("@tipofirmantewarrant", autorizacionusuario.TipoFirmanteWarrant);
        //    param.Add("@tipofirmanteliberacion", autorizacionusuario.idTipoFirmanteLIBERACIONES);
        //    param.Add("@idTipoFirmanteprorroga", autorizacionusuario.idTipoFirmantePRORROGAS);
        //    param.Add("@representante", autorizacionusuario.codigorepresentante);
        //    param.Add("@recibecorreo", autorizacionusuario.recibecorreo);
        //    //param.Add("@contrasenafirma", autorizacionusuario.firma);

        //    try
        //    {
        //        objSql.ExecuteNonQuery("USP_actualizar_autorizacionusuario", param);

        //        procesorolusuarioDAO proceso = new procesorolusuarioDAO();
        //        proceso.EliminarAutorizacionProcesoRol(autorizacionusuario.idautorizacionusuario);

        //        foreach (var item in autorizacionusuario.procesosUsuario)
        //        {
        //            item.idempresa = autorizacionusuario.idempresa;
        //            item.codigounico = autorizacionusuario.codigounico;
        //            item.tipoentidad = autorizacionusuario.tipoentidad;
        //            item.estado = true;
        //            item.idautorizacionusuario = autorizacionusuario.idautorizacionusuario;

        //            proceso.actualizarRolUsuario(item);
        //        }

        //        resultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario actualizar", "actualizar", ex);
        //        resultado = false;
        //    }
        //    //Rutina de Guardado en Log 
        //    return resultado;

        //}


        public bool EliminarAutorizacionusuario(int idautorizacionusuario)
        {

            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@idautorizacionusuario", idautorizacionusuario);
            try
            {
                objSql.ExecuteNonQuery("USP_eliminar_Autorizacionusuario", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario elminar", "EliminarAutorizacionusuario", ex);
                
            }
            //Rutina de Guardado en Log 
            return resultado;
        }

        public List<rol> ListarRol()
        {
            SqlManager objSql = new SqlManager();
            List<rol> lista = new List<rol>();
            try
            {
                lista = objSql.getStatement<rol>("USP_listar_rol", null);

            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "ListarRol", "ListarRol", ex);

            }
            return lista;
        }


        public List<Autorizacionusuario> ListarCombo()
        {
            SqlManager objSql = new SqlManager();
            List<Autorizacionusuario> lista = new List<Autorizacionusuario>();
            try
            {
                lista = objSql.getStatement<Autorizacionusuario>("USP_listar_autorizacionusuario", null);

            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario ListarCombo", "ListarCombo", ex);
            }
            return lista;
        }

        //public bool recibecorreo(Autorizacionusuario autorizacionusuario, ref string mensaje)
        //{
        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();
        //    param.Add("@idautorizacionusuario", autorizacionusuario.idautorizacionusuario);
        //    param.Add("@valor", autorizacionusuario.valor);

        //    try
        //    {
        //        objSql.ExecuteNonQuery("USP_recibecorreo_autorizacionusuario", param);
        //        resultado = true;
        //        mensaje = "ok";
        //    }
        //    catch (SqlException ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario recibecorreo", "recibecorreo", ex);
        //        mensaje = "Error" + ex.Message;
        //        throw ex;

        //    }

        //    return resultado;
        //}


        public List<Unidadmedida> listarentidad(string codigoentidad)
        {
            List<Unidadmedida> autorizacionusuario = new List<Unidadmedida>();
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@codigoentidad", codigoentidad);

            try
            {
                autorizacionusuario = objSql.getStatement<Unidadmedida>("USP_listar_codigoentidad_por_codigounico", param);

            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario listarentidad", "listarentidad", ex);
                throw new Exception(ex.Message);
            }
            //lista autorizacionusuario
            return autorizacionusuario;

        }



        public Autorizacionusuario validarcorreo(string correo)
        {

            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            Autorizacionusuario lista = new Autorizacionusuario();

            param.Add("@correo", correo);


            try
            {
                lista = objSql.getStatement<Autorizacionusuario>("USP_validar_correo_autorizacion_create", param)[0];
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcorreo", "validarcorreo", ex);

            }        //Rutina de Guardado en Log           

        }

        public Autorizacionusuario validarcuenta(string cuenta)
        {

            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            Autorizacionusuario lista = new Autorizacionusuario();

            param.Add("@cuenta", cuenta);


            try
            {
                lista = objSql.getStatement<Autorizacionusuario>("USP_validar_cuenta_autorizacion_create", param)[0];
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcuenta", "validarcuenta", ex);

            }
            //Rutina de Guardado en Log 
        }

        public bool RegistroRol(rol rol)
        {
            bool resultado = false;
            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            Autorizacionusuario lista = new Autorizacionusuario();

            param.Add("@idSociedadLogistica", rol.idSociedadLogistica);
            param.Add("@CodigoRol", rol.CodigoRol);
            param.Add("@DescripcionRol", rol.DescripcionRol);

            try
            {
                objSql.ExecuteNonQuery("SEG_USP_Rol_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;                
            }
            return resultado;
        }

        public List<MenuOpcion> ListarMenus()
        {
            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            List<MenuOpcion> lista = new List<MenuOpcion>();

            try
            {
                lista = objSql.getStatement<MenuOpcion>("SEG_USP_MenuOpcion_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcuenta", "validarcuenta", ex);
            }
        }
        public List<MenuOpcion> ChangeMenuPorAplicacion(int idusuario)
        {
            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            param.Add("@idaplicacion", idusuario);
            List<MenuOpcion> lista = new List<MenuOpcion>();

            try
            {
                lista = objSql.getStatement<MenuOpcion>("SEG_USP_MenuOpcionPorAplicacion_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcuenta", "validarcuenta", ex);

            }
            //Rutina de Guardado en Log 
            
        }
        public bool GuardarMenuRolAplicacion(string nommenu, string rol, string aplicacion,string codigosociedad)
        {
            bool resultado = false;
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();            

            param.Add("@nommenu", nommenu);
            param.Add("@rol", rol);
            param.Add("@aplicacion", Convert.ToInt32(aplicacion));
            param.Add("@codigosociedad", codigosociedad);

            try
            {
                objSql.ExecuteNonQuery("SEG_USP_MenuOpcion_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;                
            }
            return resultado;
        }
        public bool GuardarMenuRolAplicacionHijo(string nommenu, string rol, string aplicacion, int jerarquia,int idpadre)
        {
            bool resultado = false;
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();

            param.Add("@nommenu", nommenu);
            param.Add("@rol", rol);
            param.Add("@aplicacion", Convert.ToInt32(aplicacion));
            param.Add("@jerarquia", jerarquia);
            param.Add("@idpadre", idpadre);
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_MenuOpcionHijo_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return resultado;
        }




        public int GuardarMenuRolAplicacionPadre(string nommenu,string rol,string aplicacion)
        {
            int resultado;
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();

            param.Add("@nommenu", nommenu);
            param.Add("@rol", rol);
            param.Add("@aplicacion", Convert.ToInt32(aplicacion));
            try
            {
                MenuOpcion menu = objSql.getStatement<MenuOpcion>("SEG_USP_MenuOpcionPadre_Ins", param)[0];
                resultado = menu.idMenuOpcion;
                return resultado;
            }     
            catch(Exception ex)
            {
                throw ex;
            }       
        }

        public List<MenuOpcion> ListarPadres()
        {
            SqlManager objSql = new SqlManager();

            Parameter param = new Parameter();
            List<MenuOpcion> lista = new List<MenuOpcion>();

            try
            {
                lista = objSql.getStatement<MenuOpcion>("SEG_USP_MenuOpcion_LstPadres", param);
                return lista;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcuenta", "validarcuenta", ex);
                throw ex;
            }
            //Rutina de Guardado en Log 
            
        }

        public List<paginaroles> EditarFunciones(string rol,int idaplicacion)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@rol", rol);
            param.Add("idaplicacion", idaplicacion);
            List<paginaroles> lista = new List<paginaroles>();

            try
            {
                lista = objSql.getStatement<paginaroles>("SEG_USP_RolFuncion_Lst", param);
                return lista;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "Autorizacionusuario validarcuenta", "validarcuenta", ex);
                throw ex;
            }
        }

        public bool GuardarRolAplicacionFunciones(string nombremenu, paginaroles paginarol,string  rol,int aplicacion)
        {
            bool resultado = false;
        SqlManager objSql = new SqlManager();
        Parameter param = new Parameter();

            param.Add("@nombremenu", nombremenu);
            param.Add("@funcionall",paginarol.FuncionAll);
            param.Add("@funcionborrar", paginarol.FuncionBorrar);
            param.Add("@funcionactualiza", paginarol.FuncionActualiza);
            param.Add("@funcioningreso", paginarol.FuncionIngreso);
            param.Add("@funcionlectura", paginarol.FuncionLectura);
            param.Add("@rol", rol);
            param.Add("@idaplicacion", aplicacion);            
            try
            {
                objSql.ExecuteNonQuery("SEG_USP_PaginaRoles_Ins", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }
        public List<paginaroles> RolSeleccionado(string rol,int idmenuopcion,string codigosociedad)
        {            
            SqlManager objsql = new SqlManager();
            Parameter param = new Parameter();
            List<paginaroles> paginas = new List<paginaroles>();
            param.Add("@rol", rol);
            param.Add("@idmenuopcion", idmenuopcion);
            param.Add("@codigosociedad", codigosociedad);
            try
            {
                paginas = objsql.getStatement<paginaroles>("SEG_USP_RolSeleccionado", param);
                return paginas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool EliminacionMenuRolAplicacion(string rol,int idaplicacion,string codigosociedad)
        {
            bool resultado;
            SqlManager objsql = new SqlManager();
            Parameter param = new Parameter();            
            param.Add("@rol", rol);
            param.Add("@idaplicacion", idaplicacion);
            param.Add("@codigosociedad", codigosociedad);
            try
            {
                objsql.ExecuteNonQuery("SEG_USP_MenuOpcion_Del", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }


        //public bool actualizar_clave(Autorizacionusuario autorizacionusuario)
        //{
        //    SqlManager objSql = new SqlManager();
        //    bool resultado = false;
        //    Parameter param = new Parameter();


        //    param.Add("@idautorizacionusuario", autorizacionusuario.idautorizacionusuario);
        //    param.Add("@clave", autorizacionusuario.clave);
        //    param.Add("@contrasenafirma", autorizacionusuario.firma);

        //    try
        //    {
        //        objSql.ExecuteNonQuery("USP_actualizar_autorizacionusuario_clave", param);
        //        resultado = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        //afilogDAO.Save(0, 0, "Autorizacionusuario actualizar_clave", "actualizar_clave", ex);
        //        resultado = false;
        //    }
        //    //Rutina de Guardado en Log 
        //    return resultado;

        //}
    }
}



