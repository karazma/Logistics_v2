using System.Web;
using System.Web.Optimization;

namespace Logistics
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/plugins/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/plugins/jquery/jquery-min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/plugins/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Scripts/Content/dist/js/adminlte.js"));


            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                     "~/Scripts/plugins/chart.js/Chart.min.js",
                     "~/Scripts/Content/dist/js/demo.js",
                     "~/Scripts/Content/dist/js/pages/dashboard3.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/dist/css/adminlte.min.css",
                      "~/Scripts/plugins/fontawesome-free/css/all.min.css"));
        }
    }
}
