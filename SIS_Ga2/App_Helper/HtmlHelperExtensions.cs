using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SIS_Ga2.App_Helper
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString IIF(this HtmlHelper htmlHelper, Boolean condition, string SideTrue, string SideFalse)
        {
            return new HtmlString(condition ? SideTrue : SideFalse);
        }

        public static String EnabledIfMenorCero(this HtmlHelper htmlHelper, Int32 value)
        {
            return value > 0 ? "" : "disabled";
        }

        public static string CurrentController(this HtmlHelper html)
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction) viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            return currentController;
        }

        public static string IsSelectedControler(this HtmlHelper html, string controllers = "", string parameter = "", string cssClass = "current")
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction) viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            if (String.IsNullOrEmpty(controllers)) controllers = currentController;

            string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            return acceptedControllers.Contains(currentController) ? cssClass : String.Empty;
        }
        public static string IsSelectedDetail(this HtmlHelper html, string ruta = "", string cssClass = "current")
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction)
                viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();
            String rutaServidor = String.Format("{0}/{1}", currentController, currentAction).ToUpper();
            //if (ruta.Split('/').Length > 1 && String.IsNullOrEmpty(ruta.Split('/')[1])) ruta += "index";
            return rutaServidor.Replace("INDEX", "") == ruta.ToUpper() ? cssClass : String.Empty;
        }
        public static string IsSelectedControler(this HtmlHelper html, string controllers = "", string cssClass = "current")
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction) viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            if (String.IsNullOrEmpty(controllers)) controllers = currentController;

            string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            return acceptedControllers.Contains(currentController) ? cssClass : String.Empty;
        }

        public static string IsSelected(this HtmlHelper html, string controllers = "", string actions = "", string cssClass = "current")
        {
            ViewContext viewContext = html.ViewContext;
            bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

            if (isChildAction)
                viewContext = html.ViewContext.ParentActionViewContext;

            RouteValueDictionary routeValues = viewContext.RouteData.Values;
            string currentAction = routeValues["action"].ToString();
            string currentController = routeValues["controller"].ToString();

            if (String.IsNullOrEmpty(actions))
                actions = currentAction;

            if (String.IsNullOrEmpty(controllers))
                controllers = currentController;

            string[] acceptedActions = actions.Trim().Split(',').Distinct().ToArray();
            string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

            return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ? cssClass : String.Empty;
        }
    }
}