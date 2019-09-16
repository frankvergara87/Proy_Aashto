using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;
using System.IO;

namespace SIS_Ga2.Controllers
{
    public class AplicacionesController : Controller
    {
        AplicacionBL objaplicacion = new AplicacionBL();
        // GET: Cliente
        public ActionResult Index()
        {
            Autorizacionusuario usuario = new Autorizacionusuario();
            usuario = ((Autorizacionusuario)Session["sistema.usuario"]);
            if (usuario == null) return RedirectToAction("Login", "Seguridad");
            return View();
        }

     
        public IEnumerable<System.Web.Mvc.SelectListItem> ComboTipoCliente(string CodigoTipoCliente)
        {
            CatalogoBL   objBL = new CatalogoBL();
            List<Catalogo> Lista = new List<Catalogo>();
            Lista = objBL.ListarPorTipo("TIPO_CLIENTE");
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.Add(new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" });
            foreach (Catalogo c in Lista)
                data_list.Add(new SelectListItem() { Text = c.Valor , Value = Convert.ToString(c.IdCatalogo) });

            if (CodigoTipoCliente == "0")
            {
                return new SelectList(data_list, "Value", "Text");
            }
            else
            {
                return new SelectList(data_list, "Value", "Text", CodigoTipoCliente);
            }
        }

      

        public JsonResult ListarAplicacion()
        {
                List<Aplicacion> aplicaciones =  objaplicacion.ListarAplicacion();
               return Json(aplicaciones, JsonRequestBehavior.AllowGet);            
        }


        [HttpPost]
        public ActionResult RegistrarAplicacion(Aplicacion aplicacion)
        {
            try
            {
                string CarpetaImg = System.Configuration.ConfigurationManager.AppSettings["RutaDirectorioImagenUsuario"].ToString();
                string Filename = aplicacion.upload.FileName;
                string Extension = Path.GetExtension(aplicacion.upload.FileName);
                if (Extension == ".jpg" || Extension == ".gif" || Extension == ".png")
                {
                    //Filename += Extension;
                    bool exists = Directory.Exists(CarpetaImg + @"\");
                    if (exists)
                        aplicacion.upload.SaveAs(CarpetaImg + @"\" + Filename);
                    string urlimagen = CarpetaImg + @"\" + Filename;
                    aplicacion.ImagenUrl = urlimagen;
                    bool resultado = objaplicacion.RegistrarAplicacion(aplicacion);
                }
                else
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public JsonResult EditarUsuario(string idusuario)
        {
            //    Usuario usuario = objusuario.EditarUsuario(Convert.ToInt32(idusuario));
            // return Json(usuario, JsonRequestBehavior.AllowGet);
            return Json("");
        }
        public JsonResult ActualizarUsuario(string cuenta,string nombre,string apellidos,string dni,string celular,string cargo,string chkrecibe,string correo,string idlanguage,string idusuario,string clave,string estado)
        {
            //Usuario usuario = new Usuario();
            //usuario.cuenta = cuenta;
            //usuario.Nombre = nombre;
            //usuario.Apellidos = apellidos;
            //usuario.DNI = dni;
            //usuario.Celular = celular;
            //usuario.Cargo = cargo;
            //usuario.RecibeCorreo = Convert.ToBoolean(chkrecibe);
            //usuario.Correo = correo;
            //usuario.Idlanguage = Convert.ToInt32(idlanguage);
            //usuario.idautorizacionusuario = Convert.ToInt32(idusuario);
            //usuario.Estado = Convert.ToBoolean(estado);
            //if (clave != null && clave != "") usuario.clave = clave;
            //else usuario.clave = "";
            //bool resultado = objusuario.ActualizarUsuario(usuario);
            //return Json(resultado, JsonRequestBehavior.AllowGet);
            return Json("");
        }
    }
}