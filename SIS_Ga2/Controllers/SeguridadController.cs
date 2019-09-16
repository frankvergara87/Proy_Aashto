using SIS_Ga2.Business;
using SIS_Ga2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SIS_Ga2.Controllers
{
    public class SeguridadController : Controller
    {
        // GET: Seguridad
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            try
            {
                //HtmlSendMessage.SendMessage(new System.Collections.Generic.List<MessageTo>() { new MessageTo() { mailTo = "victor.lema@ga2.com.pe" } }, "Prueba de correo", "mensaje de prueba", false);
                bool usaAzure = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["UsaAzure"].ToString());
                if (usaAzure)  return RedirectToAction("Index", "Account");
                else return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpGet]
        public ActionResult Login_()
        {
            try
            {
                //HtmlSendMessage.SendMessage(new System.Collections.Generic.List<MessageTo>() { new MessageTo() { mailTo = "victor.lema@ga2.com.pe" } }, "Prueba de correo", "mensaje de prueba", false);
                bool usaAzure = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["UsaAzure"].ToString());
                if (usaAzure) return RedirectToAction("Index", "Account");
                else return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        public ActionResult IniciarSesion()
        {
            Usuario usuario = new Usuario();
            Sistema sistema = new Sistema();
            usuario.cuenta = Request.Params["user"].ToString();
            usuario.clave = Request.Params["password"].ToString();
            
            SistemaBL autorizacion = new SistemaBL();
            usuario = autorizacion.login(usuario);

            if (usuario.cuenta != null)
            {
                AplicacionBL objBL = new AplicacionBL();
                List<Aplicacion> Aplicaciones = objBL.ListarAplicaciones();

                sistema.cuenta = usuario.cuenta;
                sistema.clave = usuario.clave;
                sistema.idUsuario = usuario.idUsuario;


                Session.Add("sistema.usuario", usuario);
                Session.Add("sistema.general",sistema);

                return RedirectToAction("Aplicaciones", "Seguridad");
                //return RedirectToAction("Index", "Home");
            }
            
           
            return RedirectToAction("Login", "Seguridad");
            
            //if (usuario.cuenta != null)
            //{
            //    EmpresaBL empresabl = new EmpresaBL();
            //    Empresa SelectedEmpresa = empresabl.obtener(usuario.idAutorizacionusuario);
            //    AplicacionBL objBL = new AplicacionBL();

            //    List<Aplicacion> Aplicaciones = objBL.ListarAplicacionesPorUsuarioSociedad(usuario.idAutorizacionusuario, usuario.ListaSociedades[0].idSociedadLogistica);

            //    usuario.BESociedades_Logistica = usuario.ListaSociedades[0];
            //if (Aplicaciones != null)
            //{
            //    if (Aplicaciones.FindAll(a => a.Estado == true).Count>=1)
            //    {
            //        usuario.IdAplicacion = Aplicaciones.Find(a => a.Estado == true).IdAplicacion;
            //        usuario.BESociedades_Logistica = usuario.ListaSociedades[0];
            //        return RedirectToAction("Index", "Home");
            //    }
            //}
            //usuario.Culture = UILanguageManagerBL.GetLanguageCode(usuario.idlanguage);
            //Session.Add("sistema.usuario", usuario);

            //Session.Add("nombreusuario", usuario.Nombre);               
            //Session.Add("Codigo_Sociedad", usuario.BESociedades_Logistica.Codigo_Sociedad);
            //Session.Add("idUsuario", usuario.idAutorizacionusuario);
            //Session.Add("culture", usuario.Culture);
            //Session.Add("SelectedEmpresa", String.Empty);
            //    return RedirectToAction("Index", "Home");
            //}
            //else
            //{
            //    Session["log"] = "Error";
            //    return RedirectToAction("Login", "Seguridad");
            //}
        }

        public ActionResult Logout()
        {
            //bool usaAzure = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["UsaAzure"].ToString());

            //if (usaAzure)
            //{
            //    HttpContext.GetOwinContext().Authentication.SignOut(OpenIdConnectAuthenticationDefaults.AuthenticationType, CookieAuthenticationDefaults.AuthenticationType);
            //}

            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            System.Web.Security.FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Seguridad");
        }

        [HttpGet]
        public ActionResult Aplicaciones()
        {
            Usuario usuario = Session["sistema.usuario"] as Usuario;
            if (usuario == null) return RedirectToAction("Login", "Seguridad");

            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        [HttpPost]
        public ActionResult Aplicaciones(int IdAplicacion)
        {
            try
            {
                Usuario usuario = (Usuario)Session["sistema.usuario"];
                Sistema sistema = (Sistema)Session["sistema.general"];
                sistema.idAplicacion = IdAplicacion;
                usuario.Aplicacion = IdAplicacion;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        public JsonResult MostrarAplicaciones()
        {
            try
            {
                AplicacionBL objBLApp = new AplicacionBL();
                List<Aplicacion> objLista = objBLApp.ListarAplicaciones();
                TempData.Remove("Seguridad.Aplicaciones");
                TempData.Add("Seguridad.Aplicaciones", objLista);

                Autorizacionusuario usuario = (Autorizacionusuario)Session["sistema.usuario"];
                var resultado = "OK";
                return Json(resultado, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json("NO-OK:" + ex.Message);
            }
        }

    }
}