using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;

namespace SIS_Ga2.Controllers
{
    public class DisenoController : Controller
    {
        // GET: Diseno
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListarParametrosxTipoDiseno(int idTipoDiseno)
        {
            DisenoBL objDiseno = new DisenoBL();
            List<ParametrosDiseno> ParametroDiseno = new List<ParametrosDiseno>();
            ParametroDiseno = objDiseno.ListarParametrosxTipoDiseno(idTipoDiseno);
            return Json(ParametroDiseno, JsonRequestBehavior.AllowGet);
        }

        public List<SelectListItem> ComboPeriodo()
        {
            List<Periodo> Periodos = new List<Periodo>();
            GenericController Obj = new GenericController();
            Periodos = Obj.ListarPeriodos();
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(Periodos.OrderBy(a => a.idPeriodo).Select(a => new SelectListItem() { Text = a.DescripcionPeriodo.ToUpper(), Value = Convert.ToString(a.CantPeriodo) }));

            return data_list;

        }

        public JsonResult RegistraConfianza()
        {
            ConfianzaController R = new ConfianzaController();
            R.Index();

            //View("Index", "Confianza");
            return Json(0, JsonRequestBehavior.AllowGet);

        }

    }
}