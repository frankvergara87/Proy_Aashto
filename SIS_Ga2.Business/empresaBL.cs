using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.Business
{
    public class EmpresaBL
    {
        public static String GetCodigoEmpresa(Int32 idempresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.GetCodigoEmpresa(idempresa);
        }
        public static String GetUsuarioEmpresa(Int32 idempresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.GetUsuarioEmpresa(idempresa);
        }
        public static String GetCodigoDivisionEmpresa(Int32 idempresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.GetCodigoDivisionEmpresa(idempresa);
        }
        public static String GetCodigoDivisionEmpresaByCodigo(String Codigo)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.GetCodigoDivisionEmpresaByCodigo(Codigo);
        }
        public static String GetNombreEmpresa(Int32 idempresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.GetNombreEmpresa(idempresa);
        }

        //Metodo de Logica de datos : Registrar para la tabla empresa
        public bool registrar(Empresa empresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.registrar(empresa);

        }

        //----------------------------------------
        //Metodo de Logica de datos : Actualizar para la tabla empresa
        public bool actualizar(Empresa empresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.actualizar(empresa);

        }

        //----------------------------------------
        //Metodo de Logica de datos : Obtener registro para la tabla empresa
        public Empresa obtener(Int32 idempresa)
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.obtener(idempresa);

        }

        //----------------------------------------
        //Metodo de Logica de datos : Obtener registro para la tabla empresa
        public List<Empresa> listar()
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.listar();

        }

        //----------------------------------------


        public static List<Empresa> ListarEmpresas()
        {
            EmpresaDAO objDAO = new EmpresaDAO();
            return objDAO.listar();
        }
    }
}
