using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLDisenos
    {

        public List<BEDiseno> ListarDisenoxId(int idDiseno)
        {
            DACDiseno objDAO = new DACDiseno();
            return objDAO.ListarDisenoxId(idDiseno);
        }

        public List<BEDiseno> ListarDisenos()
        {
            DACDiseno objDAO = new DACDiseno();
            return objDAO.ListarDisenos();
        }
    }
}
