using System.Web;
using System.Web.Optimization;

namespace Sistema.Infantil
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/plugins/metisMenu/jquery.metisMenu.js",
                      "~/Scripts/sb-admin.js"));

            bundles.Add(new StyleBundle("~/Content/login").Include(
                      "~/Content/bootstrap.min.css",
                      "~/font-awesome/css/font-awesome.css",
                      "~/Content/sb-login.css"));
        }
    }
}
