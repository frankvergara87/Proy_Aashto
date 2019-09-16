using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;
namespace SIS_Ga2.Controllers
{
    public class SociedadLogisticaController : Controller
    {
        // GET: SociendadLogistica
        public ActionResult Index()
        {
            Sociedades_LogisticaBL objBL = new Sociedades_LogisticaBL();
            //List<Sociedades_Logistica> objLst = objBL.ListarSociedades_Logistica("");
            return View();
        }

        [HttpGet]
        public ActionResult Registrar()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Sociedades_Logistica objEntidad)
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");

            Sociedades_LogisticaBL objBL = new Sociedades_LogisticaBL();
            //objEntidad.estado = true;
            if (!objBL.Registrar(objEntidad))
                return RedirectToAction("ErrorPagina", "Seguridad");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Actualizar(string  Codigo_Sociedad)
        {
            Sociedades_LogisticaBL objBL = new Sociedades_LogisticaBL();
            //Sociedades_Logistica objBE = objBL.ListarSociedades_Logistica(Codigo_Sociedad)[0];
            return View();
        }



        [HttpPost]
        public ActionResult Actualizar(Sociedades_Logistica objEntidad)
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");

            Sociedades_LogisticaBL objBL = new Sociedades_LogisticaBL();
            //objEntidad.estado = true;
            if (!objBL.Actualizar(objEntidad))
                return RedirectToAction("ErrorPagina", "Seguridad");
            return RedirectToAction("Index");
        }

    }
}