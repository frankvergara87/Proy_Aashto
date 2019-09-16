using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIS_Ga2.Entity;
using SIS_Ga2.DataAccess;

namespace SIS_Ga2.Business
{
  public class TransportistasBL
    {
        TransportistasDAO DAO = new TransportistasDAO();
     public  List<Transportistas> listar_transportistas()
        {
            return DAO.listar_transportistas();
        }
        public List<Transportistas> obtener_RazonsocialTransportistas()
        {
            return DAO.obtener_RazonsocialTransportistas();
        }
        public bool eliminar_transportistas(string ruc)
        {
            return DAO.eliminar_transportistas(ruc);
        }
        public Transportistas seleccionartransportista(int numerador)
        {
            return DAO.seleccionartransportista(numerador);
        }
        public bool actualizartransportistas(Transportistas transportista)
        {
            return DAO.actualizartransportistas(transportista);
        }

        public int obtenernumerador(int codigosociedad, string tipocontrol)
        {
            return DAO.obtenernumerador(codigosociedad, tipocontrol);
        }

        public bool registrartransportistas(Transportistas transportistas)
        {
            return DAO.registrartransportistas(transportistas);
        }


    }
}
