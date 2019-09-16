using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using DbManager.DataObjects;

namespace SIS_Ga2.DataAccess
{
  public  class TransportistasDAO
    {
        public List<Transportistas> listar_transportistas()
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                //param.Add("@tipoentidad", TipoEntidad);
                //param.Add("@codigounico", CodigoUnico);

             
                List<Transportistas> lista = objSql.getStatement<Transportistas>("Usp_listar_transportistas", param);

                param = null;
                objSql.Dispose();
                objSql = null;

                return lista;
            }
            catch  (Exception ex)
            {
                throw ex;
            }
        }

        public List<Transportistas> obtener_RazonsocialTransportistas()
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                //param.Add("@tipoentidad", TipoEntidad);
                //param.Add("@codigounico", CodigoUnico);


                List<Transportistas> lista = objSql.getStatement<Transportistas>("RazonsocialTransportistas_Lst", param);

                param = null;
                objSql.Dispose();
                objSql = null;

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool eliminar_transportistas(string ruc)
        {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@ruc", ruc);
                //param.Add("@codigounico", CodigoUnico);
                bool resultado = false;
            try
            {

                objSql.ExecuteNonQuery("Usp_eliminar_Empresas_Transporte", param);
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;                
            }            
        }
        public Transportistas seleccionartransportista(int numerador)
        {
            try
            {
                SqlManager objSql = new SqlManager();
                Parameter param = new Parameter();
                param.Add("@numerador", numerador);              


                Transportistas lista = objSql.getStatement<Transportistas>("USP_ListaTransportistas_Lst", param)[0];

                param = null;
                objSql.Dispose();
                objSql = null;

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool actualizartransportistas(Transportistas transportistas)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@ruc", transportistas.RUC_Transportista);
            param.Add("@nombre", transportistas.Nombre_Transportista);
            param.Add("@direccion", transportistas.Direccion_Transportista);
            param.Add("@telefono", transportistas.Telefono_Transportista);
            param.Add("@tipoempresa", transportistas.Tipo_Empresa_P_T);
            param.Add("@estado", transportistas.estado);
            param.Add("@numerador", transportistas.numerador);                      
            bool resultado = false;
            try
            {

                objSql.ExecuteNonQuery("USP_Actualizar_Transportistas", param);
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {
                resultado = false;
            }
            return resultado;
        }




        public Int32 obtenernumerador(int codigosociedad,string tipocontrol)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@codigo_sociedad", codigosociedad);
            param.Add("@control", tipocontrol);            
            try
            {

             Numerador numerador = objSql.getStatement<Numerador>("usp_obtener_siguiente_numerador", param)[0];
                return numerador.Numero_ultimo_Control;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        public bool registrartransportistas(Transportistas transportistas)
        {
            SqlManager objSql = new SqlManager();
            Parameter param = new Parameter();
            param.Add("@codigosociedad", transportistas.Codigo_Sociedad);
            param.Add("@numerador", transportistas.numerador);
            param.Add("@ruc", transportistas.RUC_Transportista);
            param.Add("@nombre", transportistas.Nombre_Transportista);
            param.Add("@direccion", transportistas.Direccion_Transportista);
            param.Add("@telefono", transportistas.Telefono_Transportista);
            param.Add("@tipo_empresa", transportistas.Tipo_Empresa_P_T);
            

            bool resultado = false;
            try
            {

                 objSql.ExecuteNonQuery("USP_Transportistas_Ins", param);
                resultado = true;                
            }
            catch (Exception ex)
            {
                resultado = false;
                throw ex;                
            }
            return resultado;
                    }







    }
}
