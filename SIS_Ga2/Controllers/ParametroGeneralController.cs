using SIS_Ga2.Entity;
using SIS_Ga2.Business;
using System.Web.Mvc;

namespace WebWarrantAfi.Controllers
{
    public class ParametroGeneralController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Autorizacionusuario usuario = Session["sistema.usuario"] as Autorizacionusuario;
            if (usuario == null) return RedirectToAction("Login", "Seguridad");
            //parametrogeneral parametro = parametrogeneralBL.GetParametroGeneralByEmpresaId(usuario.CodigoSociedad);
            //return View(parametro);
            return View();
        }

        [HttpPost]
        public ActionResult Index(parametrogeneral entity)
        {
            return View();
        }

        
        public ActionResult Save(parametrogeneral objEntidad)
        {
            try
            {
                Autorizacionusuario usuario = Session["sistema.usuario"] as Autorizacionusuario;
                if (usuario == null) return RedirectToAction("Login", "Seguridad");
                // TODO: Add update logic here
                //var objEntidad = new parametrogeneral();
                var objparametrogeneral = new parametrogeneralBL();
                parametrogeneralBL.Save(objEntidad);
               // afilogBL.Save(usuario.idautorizacionusuario, 0, "ParametroGeneral", "Save", "Guardar Parametro General", usuario.TokenAzure, usuario.ipcliente);
                return View("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}