using System.Web;
using System.Web.Optimization;

namespace SIS_Ga2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            BundleTable.EnableOptimizations = false;

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/bootstrap/css/bootstrap.min.css",
                "~/plugins/jquery-ui/jquery-ui-1.10.2.custom.css",
                "~/assets/css/plugins.css",
                "~/assets/css/responsive.css",
                "~/assets/css/icons.css",
                "~/assets/css/error.css",
                "~/assets/css/invoice.css",
                "~/assets/css/font/FontAwesome.otf",
                "~/assets/css/booststrap/fonts/glyphicons-halflings-regular.woff",
                "~/plugins/datatables/jquery.dataTables.min.css",
                "~/assets/css/EstiloTableGa2.css",
                "~/assets/css/fontawesome/font-awesome.min.css",
                "~/assets/css/alertify.css",
                "~/assets/css/alertify.rtl.min.css",
                "~/assets/css/animate.css",
                "~/assets/css/loader.css",
                "~/assets/css/main.css",
                "~/assets/css/styleCarlos.css"));
            bundles.Add(new ScriptBundle("~/Content/js").Include(

                "~/assets/js/libs/jquery-1.10.2.min.js",
                "~/plugins/jquery-ui/jquery-ui-1.10.2.custom.min.js",
                "~/bootstrap/js/bootstrap.min.js",
                "~/assets/js/libs/lodash.compat.min.js",
                "~/plugins/touchpunch/jquery.ui.touch-punch.min.js",
                "~/plugins/event.swipe/jquery.event.move.js",
                "~/plugins/event.swipe/jquery.event.swipe.js",
                "~/assets/js/libs/breakpoints.js",
                "~/plugins/respond/respond.min.js",
                "~/plugins/cookie/jquery.cookie.min.js",
                "~/plugins/slimscroll/jquery.slimscroll.min.js",
                "~/plugins/slimscroll/jquery.slimscroll.horizontal.min.js",
                "~/plugins/sparkline/jquery.sparkline.min.js",
                "~/plugins/flot/jquery.flot.min.js",
                "~/plugins/flot/jquery.flot.tooltip.min.js",
                "~/plugins/flot/jquery.flot.resize.min.js",
                "~/plugins/flot/jquery.flot.time.min.js",
                "~/plugins/flot/jquery.flot.growraf.min.js",
                "~/plugins/easy-pie-chart/jquery.easy-pie-chart.min.js",
                "~/plugins/daterangepicker/moment.min.js",
                "~/plugins/daterangepicker/daterangepicker.js",
                "~/plugins/blockui/jquery.blockUI.min.js",
                "~/plugins/fullcalendar/fullcalendar.min.js",
                "~/plugins/noty/jquery.noty.js",
                "~/plugins/noty/layouts/top.js",
                "~/plugins/noty/themes/default.js",
                "~/plugins/uniform/jquery.uniform.min.js",
                "~/plugins/select2/select2.js",
                /*cambio  16012018 tabla*/
                "~/plugins/datatables/jquery.dataTables.js",
                "~/plugins/datatables/DT_bootstrap.js",
                "~/plugins/datatables/responsive/datatables.responsive.js",
                /*cambio  16012018 tabla*/
                "~/assets/js/app.js",
                "~/assets/js/plugins.js",
                "~/assets/js/plugins.form-components.js",
                "~/Scripts/localscript.js",
                "~/assets/js/custom.js",
                "~/assets/js/demo/pages_calendar.js",
                "~/assets/js/demo/general.js",
                //"~/assets/js/demo/charts/chart_simple.js",
                "~/plugins/pickadate/picker.js",
                "~/plugins/pickadate/legacy.js",
                "~/plugins/pickadate/picker.date.js",
                "~/plugins/pickadate/picker.time.js",
                "~/plugins/bootstrap-wizard/jquery.bootstrap.wizard.min.js",
                "~/plugins/validation/jquery.validate.min.js",
                "~/plugins/validation/additional-methods.min.js",
                "~/plugins/bootstrap-wizard/jquery.bootstrap.wizard.min.js",
                "~/plugins/bootstrap-switch/bootstrap-switch.min.js",
                "~/plugins/bootbox/bootbox.min.js",
                "~/Scripts/javaga2/JavaScriptGa2.js",
                "~/plugins/datatables/jquery.dataTables.min.js",
                "~/Scripts/Modal.js",
                "~/assets/js/alertify.min.js",
                "~/Scripts/javaga2/scriptsKrlos.js"));
        }
    }
}
