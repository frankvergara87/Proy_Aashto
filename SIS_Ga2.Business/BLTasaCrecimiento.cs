using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLTasaCrecimiento
    {

        public List<BETasaCrecimiento> ListarTasaCrecimiento(int idTasaCrecimiento)
        {
            DACTasaCrecimiento objDAO = new DACTasaCrecimiento();
            return objDAO.ListarTasaCrecimiento(idTasaCrecimiento);
        }


    }
}
