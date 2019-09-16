using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;


using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;

namespace SIS_Ga2.Business
{
   public  class UIBL
    {

        public DataTable ListarPivotUI(int idautorizacionusuario)
        {
      
            UIDAO dao = new UIDAO();
            return dao.ListarPivotUI(idautorizacionusuario);
        }

        public bool RegistrarCodigoElemento(UI objEntidad)
        {
            UIDAO objDAO = new UIDAO();
            return objDAO.RegistrarCodigoElemento(objEntidad);
        }



        public bool ActualizarElementos(UI objEntidad)
        {
            UIDAO objDAO = new UIDAO();
            return objDAO.ActualizarElementos(objEntidad);
        }






    }
}
