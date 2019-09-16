using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Business;
using SIS_Ga2.Entity;
using System.Data;
using System.Web.Script.Serialization;
namespace SIS_Ga2.Controllers
{
    public class UIController : Controller
    {
        // GET: UI
        public ActionResult Index()
        {
            Autorizacionusuario usuario = Session["sistema.usuario"] as Autorizacionusuario;

            UIBL objUIBL = new UIBL();
            UILanguageBL objUILanguageBL = new UILanguageBL();
            List<UI> UILstPivot = new List<UI>();
            //    DataTable tbl = objUIBL.ListarPivotUI(usuario.idAutorizacionusuario);
            //    List<UILanguage> objLstIdiomas = objUILanguageBL.ListarIdiomas(new UILanguage { IdUILanguage = 0 });

            //    foreach (DataRow item in tbl.Rows)
            //    {
            //        UI objBE = new UI { ElementCode = item[0].ToString() };
            //        List<UILanguage> Idiomas = new List<UILanguage>();
            //        foreach (DataColumn columna in tbl.Columns)
            //        {
            //            foreach (UILanguage itemLanguage in objLstIdiomas)
            //            {
            //                UILanguage objBELanguage = new UILanguage();

            //                if (columna.ColumnName == itemLanguage.IdUILanguage.ToString())
            //                {
            //                    objBELanguage.IdUILanguage = itemLanguage.IdUILanguage;
            //                    objBELanguage.LangName = itemLanguage.LangName;
            //                    objBELanguage.ElementCaptionText = item[columna].ToString();
            //                    Idiomas.Add(objBELanguage);
            //                    break;
            //                }
            //            }
            //        }
            //        objBE.Idioma = Idiomas;
            //        UILstPivot.Add(objBE);
            //    }
            //    return View(UILstPivot);

            //}

            //[HttpPost]
            //public JsonResult RegistrarElementos(string UI)
            //{
            //    var serializer = new JavaScriptSerializer();
            //    var dict = serializer.Deserialize<UI>(UI);

            //    return Json("OK");
            return View();
        }

        // GET: Idioma/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(string ElementCode)
        {
            var objUI = new UIBL();
            var objEntidad = new UI();
            objEntidad.ElementCode = ElementCode;
            objUI.RegistrarCodigoElemento(objEntidad);
            return Json("OK");
        }

        [HttpPost]
        public JsonResult Actualizar(string UI)
        {
            //Primera Forma
            UIBL objUI = new UIBL();
            List<UILanguage> objLista = new List<UILanguage>();
            JavaScriptSerializer objJSSerializer = new JavaScriptSerializer();
            objLista = objJSSerializer.Deserialize<List<UILanguage>>(UI);
            foreach (UILanguage item in objLista)
            {
                objUI.ActualizarElementos(new UI { ElementCode = item.ElementCode, IdUILanguage = item.IdUILanguage, ElementCaptionText = item.ElementCaptionText });
            }
            return Json("OK");
        }

    }

}