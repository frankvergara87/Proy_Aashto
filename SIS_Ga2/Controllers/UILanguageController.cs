using SIS_Ga2.Business;
using SIS_Ga2.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIS_Ga2.Controllers
{
    public class UILanguageController : Controller
    {
        // GET: UILanguage/ Index
        public ActionResult Index()
        {
            UILanguageBL objUILanguageBL = new UILanguageBL();
            UILanguage objUILanguage = new UILanguage();
            List<UILanguage> list = objUILanguageBL.ListarIdiomas(new UILanguage() { IdUILanguage = 0 });
            return View(list);
        }


        // GET: Idioma/Create
        public ActionResult Create()
        {
            UILanguageBL objBL = new UILanguageBL();
            return View(objBL.ObtenerNroOrdenMaximo());
        }


        // POST: UILanguage/Create
        [HttpPost]
        public ActionResult Create(UILanguage objEntidad)
        {
            try
            {

                UILanguageBL BL = new UILanguageBL();
                if (!BL.RegistrarIdiomas(objEntidad))
                {
                    ViewBag.Mensaje = "No se puede registrar porque el número de orden ya existe";
                    return View();
                }
                else
                    return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }


        //GET:UILanguage/Edit/5
        public ActionResult Edit(int Id)
        {
            UILanguage objEntidad = new UILanguage();
            UILanguageBL BL = new UILanguageBL();
            objEntidad.IdUILanguage = Id;
            UILanguage obj = BL.ObtenerIdioma(objEntidad);
            return View(obj);

        }

        // POST: UILanguage/Edit/5
        [HttpPost]
        public ActionResult Edit(UILanguage objEntidad)
        {
            try
            {
                // TODO: Add update logic here
                UILanguageBL BL = new UILanguageBL();
                if (!BL.ActualizarIdiomas(objEntidad))
                {
                    ViewBag.Mensaje = "No se puede actualizar porque el número de orden ya existe";
                    return View();
                }
                else
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: UILanguageBL/Delete/5
        public ActionResult Delete(int id)
        {
            UILanguage objEntidad = new UILanguage();
            UILanguageBL BL = new UILanguageBL();
            objEntidad.IdUILanguage = id;
            UILanguage obj = BL.ObtenerIdioma(objEntidad);
            return View(obj);
        }


        [HttpPost]
        public ActionResult Delete(UILanguage objEntidad)
        {
            try
            {
                // TODO: Add update logic here
                UILanguageBL BL = new UILanguageBL();
                BL.EliminarIdiomas(objEntidad);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //public ActionResult ChangeLanguage(string lang)
        //{
        //    Autorizacionusuario usuario = Session["sistema.usuario"] as Autorizacionusuario;
        //    if (usuario == null) return RedirectToAction("Login", "Seguridad");

        //    usuario.idlanguage = Convert.ToInt32(lang);
        //    usuario.Culture = UILanguageManagerBL.GetLanguageCode(usuario.idlanguage);

        //    Session["sistema.usuario"] = usuario;
        //    Session["culture"] = usuario.Culture;

            

        //    //Int32 valor = 1;
        //    //List<MenubarOpcion> MenuOpciones = Session["MenuBarOpciones"] as List<MenubarOpcion>;
        //    //Session.Remove("MenuBarOpciones");

        //    //if (usuario != null)
        //    //    {
        //    //        valor = usuario.tipoentidad == "A" ? 1 : (usuario.tipoentidad == "B" ? 2 : 3);
        //    //        List<procesorolusuario> RolesUsuario = ransa.warrants.business.ProcesoBL.GetProcesoRolUsuarioByUsuarioId(usuario.idautorizacionusuario);
        //    //        if (RolesUsuario.Count > 0)
        //    //        {
        //    //            List<Int32> RolesByUsuario = RolesUsuario.GroupBy(a => a.idrol).Select(a => a.Key).ToList();

        //    //            foreach (Int32 RolId in RolesByUsuario)
        //    //            {
        //    //                List<MenubarOpcion> MenuOpcionesRol = ransa.warrants.business.menuOpcionBL.GetMenubarOpciones(RolId, Convert.ToInt32(lang), 1, usuario.tipoentidad);
        //    //                if (MenuOpciones == null) { MenuOpciones = new List<MenubarOpcion>(); }
        //    //                MenuOpciones.AddRange(MenuOpcionesRol);
        //    //            }

        //    //            Session["MenuBarOpciones"] = MenuOpciones;
        //    //        }
        //    //    }  

        //    //if (CodigoEmpresa == "AM")
        //    //{
        //    //    return RedirectToAction("Alma_get", "Tablero");
        //    //}
        //    //else if (CodigoEmpresa == "LZ")
        //    //{
        //    //    return RedirectToAction("Casa", "Tablero");
        //    //}


        //    return RedirectToAction("Index", "Home");

        //}

        //[HttpPost]
        //public JsonResult uiElements(string lang)
        //{
        //    Autorizacionusuario usuario = Session["sistema.usuario"] as Autorizacionusuario;
        //    if (usuario == null) return Json(String.Empty, JsonRequestBehavior.AllowGet);

        //    UILanguageManagerBL manager = new UILanguageManagerBL();
        //    List<UIElement> controles = manager.listarElementos(usuario.idlanguage);

        //    return Json(controles, JsonRequestBehavior.AllowGet);

        //}
    }
}