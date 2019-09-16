using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
    public class DisenoBL
    {
        public List<ParametrosDiseno> ListarParametrosxTipoDiseno(int idTipoDiseno)
        {
            try
            {
                DisenoDAO objDAO = new DisenoDAO();
                return objDAO.ListarParametrosxTipoDiseno(idTipoDiseno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
