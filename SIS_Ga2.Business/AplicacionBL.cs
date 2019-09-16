using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;
namespace SIS_Ga2.Business
{
    public class AplicacionBL
    {
        AplicacionDAO objDAO = new AplicacionDAO ();
        public List<Aplicacion > ListarAplicaciones()
        {
            return objDAO.ListarAplicaciones();
        }
        public List<Aplicacion> ListarAplicacion()
        {
            return objDAO.ListarAplicacion();
        }
        public bool RegistrarAplicacion(Aplicacion aplicacion)
        {
            return objDAO.RegistrarAplicacion(aplicacion);
        }

    }
}
