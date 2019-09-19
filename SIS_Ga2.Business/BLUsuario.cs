using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLusuario
    {

        public List<BEUsuario> ListarUsuariosxId(int idUsuario)
        {
            DACUsuario objDAO = new DACUsuario();
            return objDAO.ListarUsuariosxId(idUsuario);
        }

        public List<BEUsuario> ListarUsuario()
        {
            DACUsuario objDAO = new DACUsuario();
            return objDAO.ListarUsuario();
        }
    }
}
