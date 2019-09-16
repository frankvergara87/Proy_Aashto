using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
    public class Sociedades_LogisticaBL
    {
        /// <summary>
        /// Listar  Sociedades_Logistica por Codigo_Sociedad
        /// Si el Codigo_Sociedad = '' se podra listar todos los Sociedades_Logistica
        /// </summary>
        /// <param name="Codigo_Sociedad"></param>
        /// <returns></returns>
        public List<Sociedades_Logistica> ListarSociedades_Logistica()
        {
            Sociedades_LogisticaDAO  objDAO = new Sociedades_LogisticaDAO();
            return objDAO.ListarSociedades_Logistica();
        }

        public bool Registrar(Sociedades_Logistica objEntidad)
        {
            Sociedades_LogisticaDAO objDAO = new Sociedades_LogisticaDAO();
            return false;
        }

        public bool Actualizar(Sociedades_Logistica objEntidad)
        {
            Sociedades_LogisticaDAO objDAO = new Sociedades_LogisticaDAO();
            return false;
        }
        public List<Sociedades_Logistica> ListarSociedades_Logistica_PorUsuario(int IdAutorizacionUsuario)
        {
            Sociedades_LogisticaDAO objDAO = new Sociedades_LogisticaDAO();
            return objDAO.ListarSociedades_Logistica_PorUsuario(IdAutorizacionUsuario);
        }

    }
}
