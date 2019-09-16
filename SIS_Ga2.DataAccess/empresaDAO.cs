using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.DataAccess
{

    public class EmpresaDAO
    {
        public String GetUsuarioEmpresa(Int32 idempresa)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdEmpresa", idempresa);

                String CodEmpresa = objSql.ExecuteScalar("USP_Empresa_SelectUsuarioEmpresa", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "EmpresaDAO", "GetUsuarioEmpresa", ex);
                return ex.Message;
            }
        }

        public String GetCodigoEmpresa(Int32 idempresa)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdEmpresa", idempresa);

                String CodEmpresa = objSql.ExecuteScalar("USP_Empresa_SelectCodigoEmpresa", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "EmpresaDAO", "GetCodigoEmpresa", ex);
                return ex.Message;
            }
        }
        public String GetCodigoDivisionEmpresa(Int32 idempresa)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdEmpresa", idempresa);

                String CodEmpresa = objSql.ExecuteScalar("USP_Empresa_SelectCodigoDivisionEmpresa", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "EmpresaDAO", "GetCodigoDivisionEmpresa", ex);
                return ex.Message;
            }
        }
        public String GetCodigoDivisionEmpresaByCodigo(String Codigo)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@CodEmpresa", Codigo);

                String CodEmpresa = objSql.ExecuteScalar("USP_Empresa_SelectCodigoDivision", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "EmpresaDAO", "GetCodigoDivisionEmpresaByCodigo", ex);
                return ex.Message;
            }
        }
        public String GetNombreEmpresa(Int32 idempresa)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@IdEmpresa", idempresa);

                String CodEmpresa = objSql.ExecuteScalar("USP_Empresa_SelectNombreEmpresa", param).ToString();
                objSql.Dispose();
                param = null;

                return CodEmpresa;
            }
            catch (Exception ex)
            {
                //afilogDAO.Save(0, 0, "EmpresaDAO", "GetNombreEmpresa", ex);
                return ex.Message;
            }
        }

        //Metodo de acceso a Datos : Registrar para la tabla empresa
        public bool registrar(Empresa empresa)
        {

            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@nombre", empresa.nombre);
            param.Add("@estado", empresa.estado);
            try
            {
                objSql.ExecuteNonQuery("USP_registrar_empresa", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "EmpresaDAO", "registrar", ex);
                
            }
            //Rutina de Guardado en Log 
            return resultado;

        }

        //----------------------------------------
        //Metodo de acceso a Datos : Actualizar para la tabla empresa
        public bool actualizar(Empresa empresa)
        {

            SqlManager objSql = new SqlManager();
            bool resultado = false;
            Parameter param = new Parameter();

            param.Add("@idempresa", empresa.idempresa);
            param.Add("@nombre", empresa.nombre);
            param.Add("@estado", empresa.estado);
            try
            {
                objSql.ExecuteNonQuery("USP_actualizar_empresa", param);
                resultado = true;
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "EmpresaDAO", "actualizar", ex);                
            }
            //Rutina de Guardado en Log 
            return resultado;

        }

        //----------------------------------------
        //Metodo de acceso a Datos : Obtener registro para la tabla empresa
        public Empresa obtener(Int32 idempresa)
        {
            Empresa empresa = new Empresa();
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();

                param.Add("@idempresa", idempresa);

                empresa = objSql.getStatement<Empresa>("USP_obtener_empresa", param)[0];
            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "EmpresaDAO", "obtener", ex);
                //Rutina de Guardado en Log 
            }
            return empresa;
        }

        //----------------------------------------
        //Metodo de acceso a Datos : Listar todos los registros para la tabla empresa
        public List<Empresa> listar()
        {

            SqlManager objSql = new SqlManager();
            List<Empresa> empresa = new List<Empresa>();
            try
            {
                empresa = objSql.getStatement<Empresa>("USP_listar_empresa", null);

            }
            catch (Exception ex)
            {
                throw ex;
                //afilogDAO.Save(0, 0, "EmpresaDAO", "listar", ex);
            }
            //Rutina de Guardado en Log 
            return empresa;

        }

        //----------------------------------------
    }
}
