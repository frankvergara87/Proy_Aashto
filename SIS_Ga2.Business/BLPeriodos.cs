using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLPeriodos
    {

        public List<BEPeriodo> ListarPeriodos(int idPeriodo)
        {
            DACPeriodo objDAO = new DACPeriodo();
            return objDAO.ListarPeriodos(idPeriodo);
        }
        
     
    }
}
