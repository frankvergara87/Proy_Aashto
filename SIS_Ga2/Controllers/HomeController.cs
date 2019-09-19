using SIS_Ga2.Entity;
using SIS_Ga2.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.SolverFoundation.Common;
using Microsoft.SolverFoundation.Services;

namespace SIS_Ga2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Sistema usuario = Session["sistema.general"] as Sistema;
            if (usuario == null) return RedirectToAction("Login", "Seguridad");            
            return View();
        }
        public JsonResult Calcular(string n18nom,string input1,string input2)
        {
            /*
             *https://es.symbolab.com/solver/functions-graphing-calculator 
             * ddl package = using Microsoft.SolverFoundation.Services;
             * url que permite operar la formula con datos
            */

            var solver = SolverContext.GetContext();
            var model = solver.CreateModel();            
            var decisionX = new Decision(Domain.IntegerNonnegative, "X");
            var decisionY = new Decision(Domain.IntegerNonnegative, "Y");
            model.AddDecision(decisionX);
            model.AddDecision(decisionY);

            model.AddConstraints("res1", decisionY >= 100);
            model.AddGoal("formula", GoalKind.Maximize,
                -decisionX);

            double x = decisionX.GetDouble();
            double y = decisionY.GetDouble();
            //resultado = (Math.Log10((Convert.ToDouble(PSI))/(4.5-1.5)));
            //SolverContext context = SolverContext.GetContext();
            //Model model = context.CreateModel();
            //double n18nomf = Convert.ToDouble(n18nom);
            //Decision D = new Decision(Domain.RealNonnegative, "D");                       
            //model.AddDecision(D);
            //model.AddConstraints("Restriccion", D >= 10);
            //double z = Convert.ToDouble(input1);
            //double r = Convert.ToDouble(input2);
            //double calculo = Convert.ToDouble(D + 25.4);
            //model.AddGoal("Goal", GoalKind.Maximize,(z  * r) + (7.35 * D));
            //Solution solution = context.Solve(new SimplexDirective());
            //Report report = solution.GetReport();
            //double F = solution.Goals.First().ToDouble();
            return Json(x, JsonRequestBehavior.AllowGet);
        }       

        public List<SelectListItem> ComboTipoDiseno(int idTipoDiseno)
        {
            List<TipoDisenos> TipoDiseno = new List<TipoDisenos>();
            GenericController Obj = new GenericController();
            TipoDiseno = Obj.ListarTipoDiseno(idTipoDiseno);
            //List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(TipoDiseno.OrderBy(a => a.TipoDiseno).Select(a => new SelectListItem() { Text = a.TipoDiseno.ToUpper(), Value = Convert.ToString(a.IdTipoDiseno) }));

            return data_list;

        }

        public List<SelectListItem> ComboPeriodos(int idPeriodo)
        {
            List<BEPeriodo> Periodos = new List<BEPeriodo>();
            GenericController Obj = new GenericController();
            Periodos = Obj.ListarComboPeriodos(idPeriodo);
            //List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(Periodos.Select(a => new SelectListItem() { Text = a.Periodo.ToUpper(), Value = Convert.ToString(a.idPeriodo) }));

            return data_list;

        }

        public List<SelectListItem> ComboTasaCrecimiento(int idTasaCrecimiento)
        {
            List<BETasaCrecimiento> TasaCrecimiento = new List<BETasaCrecimiento>();
            GenericController Obj = new GenericController();
            TasaCrecimiento = Obj.ListarComboTasaCrecimiento(idTasaCrecimiento);
            //List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(TasaCrecimiento.Select(a => new SelectListItem() { Text = a.TasaCrecimiento.ToUpper(), Value = Convert.ToString(a.IdTasaCrecimiento) }));

            return data_list;

        }

        public List<SelectListItem> ListaTipoPavimento(int idTasaCrecimiento)
        {
            List<BETipoPavimento> TasaCrecimiento = new List<BETipoPavimento>();
            GenericController Obj = new GenericController();
            TasaCrecimiento = Obj.ListarTipoPavimentos(idTasaCrecimiento);
            //List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(TasaCrecimiento.Select(a => new SelectListItem() { Text = a.TipoPavimento.ToUpper(), Value = Convert.ToString(a.idTipoPavimento) }));

            return data_list;

        }

        public List<SelectListItem> ComboReglamento(int idReglamento)
        {
            List<Reglamentos> Reglamento = new List<Reglamentos>();
            GenericController Obj = new GenericController();
            Reglamento = Obj.ListarReglamento(idReglamento);
            //List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };
            List<SelectListItem> data_list = new List<SelectListItem>();
            data_list.AddRange(Reglamento.OrderBy(a => a.Reglamento).Select(a => new SelectListItem() { Text = a.Reglamento.ToUpper(), Value = Convert.ToString(a.idReglamento) }));

            return data_list;

        }

        //public List<TipoDisenos> ComboTipoDiseno()
        ////public IEnumerable<System.Web.Mvc.SelectListItem> comboruccliente(string CodigoSociedad, string RucSeleccionado)
        //{
        //    SelectListItem DataCombo = new SelectListItem();
        //    SolicitudesBL objBL = new SolicitudesBL();

        //    List<Cliente> Lista = new List<Cliente>();

        //    //Lista = listado de cliente del codigosociedad
        //    Lista = objBL.listar_ruc_cliente(CodigoSociedad);

        //    //data_list = listado de option del select
        //    List<SelectListItem> data_list = new List<SelectListItem> { new SelectListItem() { Text = string.Format("[{0}]", "SELECCIONAR"), Value = "0" } };

        //    //adicionando al data_list la Lista
        //    data_list.AddRange(Lista.OrderBy(a => a.IdCliente).Select(a => new SelectListItem() { Text = a.RazonSocial.ToUpper(), Value = a.NumDocumento }));


        //    if (RucSeleccionado == "0") return new SelectList(data_list, "Value", "Text");
        //    else return new SelectList(data_list, "Value", "Text", RucSeleccionado);

        //}

        [HttpPost]
        public ActionResult FormServFinal()
        {
            int valorSerFinal;
            BEParametroDiseno paramDiseno = new BEParametroDiseno();

            return RedirectToAction("Index", "Diseno");
        }
        [HttpPost]
        public ActionResult FormRegistraProyecto()
        {
            int idProyecto; 
            Proyecto Proyecto = new Proyecto();
            ProyectosController RegistraProyecto = new ProyectosController();
            Sistema Usuario = Session["sistema.general"] as Sistema;

            Proyecto.CodProyecto = Request.Form["NombreProyecto"];
            Proyecto.NumDiseno = Request.Form["Diseno"];
            Proyecto.Tramo = Request.Form["Tramo"];
            Proyecto.FecProyecto = Request.Form["Fecha"];
            Proyecto.Ubicacion = Request.Form["Ubicacion"];
            Proyecto.idReglamento = int.Parse(Request.Form["Reglamento"]);
            Proyecto.idUsuario = Usuario.idUsuario;
            Proyecto.idTipoDiseno = Usuario.idAplicacion;

            idProyecto = RegistraProyecto.GuardarProyecto(Proyecto);

            Usuario.idProyecto = idProyecto;
            Usuario.CodProyecto = Proyecto.CodProyecto;
            Usuario.idReglamento = Proyecto.idReglamento;
            Usuario.idTipoDiseno = Proyecto.idTipoDiseno;
            Usuario.TipoDiseno = Proyecto.TipoDiseno;

            return RedirectToAction("Index", "Diseno");
        }
    }
}