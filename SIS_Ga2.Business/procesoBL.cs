using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;

namespace SIS_Ga2.Business
{
    public class ProcesoBL
    {
        public static List<UsuarioRoles> GetProcesoRolUsuarioByUsuarioId(Int32 IdAutorizacionUsuario)
        {
            try
            {
                procesorolusuarioDAO objDAO = new procesorolusuarioDAO();
                return objDAO.GetProcesoRolUsuarioByUsuarioId(IdAutorizacionUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<Proceso> listaProcesos()
        //{
        //    ProcesoDAO objDAO = new ProcesoDAO();
        //    return objDAO.listar();
        //}

        //public static List<Proceso> listarProcesos()
        //{
        //    ProcesoDAO objDAO = new ProcesoDAO();
        //    return objDAO.listar();
        //}

        public static List<procesorolusuario> obtener_procesorolusuario(int id)
        {
            procesorolusuarioDAO objDAO = new procesorolusuarioDAO();
            return objDAO.obtener_procesorolusuario(id);

        }


    }
}
