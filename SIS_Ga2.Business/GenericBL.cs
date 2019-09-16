using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
    public class GenericBL
    {
        public List<TipoDisenos> ListarTipoDiseno(int idTipoDiseno)
        {
            GenericDAO objDAO = new GenericDAO();
            return objDAO.ExtraerTipoDiseno(idTipoDiseno);
        }

        public List<Reglamentos> ListarReglamentos(int idReglamento)
        {
            GenericDAO objDAO = new GenericDAO();
            return objDAO.ExtraerReglamento(idReglamento);
        }
        public List<Periodo> ListarPeriodos()
        {
            GenericDAO objDAO = new GenericDAO();
            return objDAO.ExtraerPeriodos();
        }
    }
}
