using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLTipoDiseno
    {

        public List<BETipoDiseno> ListarTipoDisenoxId(int idReglamento)
        {
            DACTipoDiseno objDAO = new DACTipoDiseno();
            return objDAO.ListarTipoDisenoxId(idReglamento);
        }

        public List<BETipoDiseno> ListarTipoDisenos()
        {
            DACTipoDiseno objDAO = new DACTipoDiseno();
            return objDAO.ListarTipoDisenos();
        }
    }
}
