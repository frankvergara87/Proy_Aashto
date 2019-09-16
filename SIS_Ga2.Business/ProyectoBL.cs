using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;

namespace SIS_Ga2.Business
{
    public class ProyectoBL
    {
        public List<Proyecto> ListarProyectos(int idTipoDiseno, int idUsuario)
        {
            ProyectoDAO objDAO = new ProyectoDAO();
            return objDAO.ListarProyectos(idTipoDiseno, idUsuario);
        }
        public int GuardarProyecto(Proyecto DataProyecto)
        {
            ProyectoDAO objDAO = new ProyectoDAO();
            return objDAO.GuardarProyecto(DataProyecto);
        }

    }
}
