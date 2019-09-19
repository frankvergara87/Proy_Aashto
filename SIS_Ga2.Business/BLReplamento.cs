using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLReglamento
    {

        public List<BEReglamentos> ListarReglamentosxId(int idReglamento)
        {
            DACReglamentos objDAO = new DACReglamentos();
            return objDAO.ListarReglamentosxId(idReglamento);
        }

        public List<BEReglamentos> ListarReglamentos()
        {
            DACReglamentos objDAO = new DACReglamentos();
            return objDAO.ListarReglamentos();
        }
    }
}
