using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;


namespace SIS_Ga2.Business
{
    public class BLProyectos
    {

        public List<BEProyecto> ListarProyectosxId(int idProyecto)
        {
            DACProyectos objDAO = new DACProyectos();
            return objDAO.ListarProyectosxId(idProyecto);
        }

        public List<BEProyecto> ListarProyectos()
        {
            DACProyectos objDAO = new DACProyectos();
            return objDAO.ListarProyectos();
        }
    }
}
