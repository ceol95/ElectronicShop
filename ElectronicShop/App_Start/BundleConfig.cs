using System.Web;
using System.Web.Optimization;

namespace ElectronicShop
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/admin/css").Include(
                      "~/Content/Admin/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/Admin/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Content/Admin/vendor/datatables/dataTables.bootstrap4.css",
                      "~/Content/Admin/css/sb-admin.css"));

            bundles.Add(new ScriptBundle("~/Content/admin/js").Include(
                "~/Content/Admin/vendor/jquery/jquery.min.js",
                "~/Content/Admin/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/Content/Admin/vendor/jquery-easing/jquery.easing.min.js",
                "~/Content/Admin/vendor/chart.js/Chart.min.js",
                "~/Content/Admin/vendor/datatables/jquery.dataTables.js",
                "~/Content/Admin/vendor/datatables/dataTables.bootstrap4.js",
                "~/Content/Admin/js/sb-admin.min.js",
                "~/Content/Admin/js/sb-admin-datatables.min.js",
                "~/Content/Admin/js/sb-admin-charts.min.js"));


            bundles.Add(new ScriptBundle("~/Content/frontPage/css").Include(
                "~/Content/FrontPage/css/bootstrap.min.css",
                "~/Content/FrontPage/css/font-awesome.min.css",
                "~/Content/FrontPage/css/prettyPhoto.css",
                "~/Content/FrontPage/css/price-range.css",
                "~/Content/FrontPage/css/animate.css",
                "~/Content/FrontPage/css/main.css",
                "~/Content/FrontPage/css/responsive.css" ));

            bundles.Add(new ScriptBundle("~/Content/frontPage/js").Include(
                "~/Content/FrontPage/js/jquery.js",
                "~/Content/FrontPage/js/bootstrap.min.js",
                "~/Content/FrontPage/js/jquery.scrollUp.min.js",
                "~/Content/FrontPage/js/price-range.js",
                "~/Content/FrontPage/js/jquery.prettyPhoto.js",
                "~/Content/FrontPage/js/main.js",
                "~/Content/FrontPage/js/price-range.js"
                ));
        }
    }
}
