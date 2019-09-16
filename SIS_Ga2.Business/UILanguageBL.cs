using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SIS_Ga2.DataAccess;
using SIS_Ga2.Entity;

namespace SIS_Ga2.Business
{
    public class UILanguageBL
    {

        public List<UILanguage> ListarIdiomas(UILanguage objEntidad)
        {
            UILanguageDAO dao = new UILanguageDAO();
            return dao.ListarIdiomas(objEntidad);
        }


        public bool RegistrarIdiomas(UILanguage Idioma)
        {
            UILanguageDAO objDAO = new UILanguageDAO();
            return objDAO.RegistrarIdiomas(Idioma );
        }

        public bool ActualizarIdiomas(UILanguage Idioma)
        {
            UILanguageDAO objDAO = new UILanguageDAO();
            return objDAO.ActualizarIdiomas (Idioma);
        }

        public UILanguage ObtenerIdioma(UILanguage objEntidad)
        {
            UILanguageDAO objDAO = new UILanguageDAO();
            return objDAO.ObtenerIdioma(objEntidad );
        }

        public UILanguage ObtenerNroOrdenMaximo()
        {
            UILanguageDAO objDAO = new UILanguageDAO();
            return objDAO.ObtenerNroOrdenMaximo();
        }

        public bool EliminarIdiomas(UILanguage Idioma)
        {
            UILanguageDAO objDAO = new UILanguageDAO();
            return objDAO.EliminarIdiomas (Idioma);
        }



    }
}
