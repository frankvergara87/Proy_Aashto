using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLTramo
    {

        public List<BETramo> ListarTramoxId(int idTramo)
        {
            DACTramo objDAO = new DACTramo();
            return objDAO.ListarTramoxId(idTramo);
        }

        public List<BETramo> ListarTipoDisenos()
        {
            DACTramo objDAO = new DACTramo();
            return objDAO.ListarTramos();
        }
    }
}
