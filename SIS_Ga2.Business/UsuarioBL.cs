using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
    public class UsuarioBL
    {
        UsuarioDAO objdao = new UsuarioDAO();
       public List<Usuario> ListarUsuario()
        {
            return objdao.ListarUsuario();
        }
		public bool RegistroUsuario(Usuario usuario)
        {
            return objdao.RegistroUsuario(usuario);
        }
        public Usuario EditarUsuario(int idusuario)
        {
            return objdao.EditarUsuario(idusuario);
        }
        public bool ActualizarUsuario(Usuario usuario)
        {
            return objdao.ActualizarUsuario(usuario);
        }
        public List<rol> ListarRolesPorSociedad(int idsociedad,int idusuario)
        {
            return objdao.ListarRolesPorSociedad(idsociedad,idusuario);
        }
        public bool AgregarRol(int idusuario,int idsociedad,int idrol)
        {
            return objdao.AgregarRol(idusuario, idsociedad, idrol);
        }
        public bool DeleteRolUsuario(int idusuario,int idsociedad)
        {
            return objdao.DeleteRolUsuario(idusuario, idsociedad);
        }
        //public List<Aplicacion> AplicacionesPorusuario(int idusuario)
        //{
        //    return objdao.AplicacionesPorusuario(idusuario);
        //}

 
    }
}
