using System.Web;
using System.Web.Optimization;

namespace InventoryLink2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js-vendor").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/DataTables/jquery.dataTables.min.js",
                      "~/Scripts/metisMenu/metisMenu.min.js",
                      "~/Scripts/raphael/raphael.min.js",
                      "~/Scripts/morrisjs/morris.min.js",
                      "~/Scripts/jquery.unobtrusive-ajax.js",
                      "~/Scripts/sb-admin/sb-admin-2.js",
                       "~/Scripts/DataTables/dataTables.bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/js-custom").Include(
                      "~/Scripts/app.js",
                      "~/Scripts/unobtrusive.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/bootstrap/bootstrap.min.css",
                      "~/Content/sb-admin/sb-admin-2.css",
                      "~/Content/metisMenu/metisMenu.min.css",
                      "~/Content/morrisjs/morris.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/DataTables/dataTables.bootstrap.min.css"));
        }
    }
}
