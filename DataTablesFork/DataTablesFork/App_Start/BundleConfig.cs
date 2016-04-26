using System.Web;
using System.Web.Optimization;

namespace DataTablesFork
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

            bundles.Add(new ScriptBundle("~/plugins/dataTables").Include(
                      "~/Scripts/plugins/dataTables/jquery.dataTables.js",
                      "~/Scripts/plugins/dataTables/dataTables.bootstrap.js",
                      "~/Scripts/plugins/dataTables/dataTables.responsive.js",
                      "~/Scripts/plugins/dataTables/dataTables.tableTools.min.js"));

            bundles.Add(new StyleBundle("~/Content/dataTables").Include(
             "~/Content/DataTable/jquery.dataTables.css",
             "~/Content/DataTable/dataTables.colVis.css",
             "~/Content/DataTable/dataTables.tableTools.css",
             "~/Content/DataTable/jquery-ui-timepicker-addon.css",
             "~/Content/DataTable/jquery.dataTables.columnFilter.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
