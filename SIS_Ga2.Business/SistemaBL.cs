using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;

namespace SIS_Ga2.Business
{
    public class SistemaBL
    {
        public Usuario login(Usuario objEntidad)
        {
            SistemasDAO objDAO = new SistemasDAO();
            return objDAO.login(objEntidad);
        }
    }
}
