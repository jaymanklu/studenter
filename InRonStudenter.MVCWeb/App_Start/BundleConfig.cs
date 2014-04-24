using System.Web;
using System.Web.Optimization;

namespace InRonStudenter.MVCWeb
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

            bundles.Add(new ScriptBundle("~/bundles/Metro-UI").Include(
                    "~/metro-js/metro.min.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                    "~/Scripts/jquery-ui-*"
                ));
            bundles.Add(new StyleBundle("~/Content/bootstrap-css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-theme.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-css-flatly").Include(
                      "~/Content/bootstrap-flatly.css"
                ));
            bundles.Add(new StyleBundle("~/Content/MetroUI-bootstrap").Include(
                "~/metro-css/metro-bootstrap-responsive.min.css",
                "~/metro-css/metro-bootstrap.min.css",
                "~/metro-css/iconFont.min.css"
                ));

            bundles.Add(new StyleBundle("~/Googlefont/lato", "http://fonts.googleapis.com/css?family=Lato").Include());

            bundles.Add(new StyleBundle("~/Content/bootstrap-css-cosmo").Include(
                "~/Content/bootstrap-cosmo.min.css"
                ));
            bundles.Add(new StyleBundle("~/Content/jquery-ui").Include(
                 "~/Content/themes/base/jquery-ui.css"
                ));
        }
    }
}
