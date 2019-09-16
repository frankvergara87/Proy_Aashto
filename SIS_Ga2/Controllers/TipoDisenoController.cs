using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIS_Ga2.Entity;
using SIS_Ga2.Business;

namespace SIS_Ga2.Controllers
{
    public class TipoDisenoController : Controller
    {
        // GET: TipoDiseno
        public ActionResult Index()
        {
            return View();
        }
    }
}