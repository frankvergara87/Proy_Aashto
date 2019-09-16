using DbManager.DataObjects;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Ga2.DataAccess
{
    public  class ClienteDAO
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
                throw ex;                
            }            
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
                //afilogDAO.Save(0, 0, "Sincronizar cliente", "registrar", ex);
                resultado = false;
            }
            //Rutina de Guardado en Log 
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
                //Rutina de Guardado en Log 
                //afilogDAO.Save(0, 0, "CatalogoDAO", "GetCatalogoToCombo", ex);
                throw ex;
            }
        }
    }
}
