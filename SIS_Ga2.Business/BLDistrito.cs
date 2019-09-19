using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLDistritos
    {

        public List<BEDistrito> ListarDistritoXId(int idDistrito)
        {
            DACDistrito objDAO = new DACDistrito();
            return objDAO.ListarDistritoXId(idDistrito);
        }

        public List<BEDistrito> ListarDistritoXProv(int idProvincia)
        {
            DACDistrito objDAO = new DACDistrito();
            return objDAO.ListarDistritoXProv(idProvincia);
        }
    }
}
