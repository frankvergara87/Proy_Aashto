using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLTipoPavimento
    {

        public List<BETipoPavimento> ListarTipoPavimento(int idTipoPavimento)
        {
            DACTipoPavimento objDAO = new DACTipoPavimento();
            return objDAO.ListarTipoPavimento(idTipoPavimento);
        }


    }
}
