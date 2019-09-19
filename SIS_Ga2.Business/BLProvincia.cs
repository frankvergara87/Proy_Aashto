using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLProvincia
    {

        public List<BEProvincia> ListarDisenoxId(int idProvincia)
        {
            DACProvincia objDAO = new DACProvincia();
            return objDAO.ListarProvinciaXID(idProvincia);
        }

        public List<BEProvincia> ListarProviciaXDep(int idDepartamento)
        {
            DACProvincia objDAO = new DACProvincia();
            return objDAO.ListarProviciaXDep(idDepartamento);
        }
    }
}
