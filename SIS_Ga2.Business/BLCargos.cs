using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLCargos
    {

        public List<BECargo> ListarCargoXId(int idCargo)
        {
            DACCargo objDAO = new DACCargo();
            return objDAO.ListarCargosxId(idCargo);
        }

        public List<BECargo> ListarCargos()
        {
            DACCargo objDAO = new DACCargo();
            return objDAO.ListarCargos();
        }
    }
}
