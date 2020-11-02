using System.Web;
using System.Web.Optimization;

namespace HamedApple.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/Main/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/Main/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/Main/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Scripts/Main/bootstrap.js",
                      "~/Content/Scripts/Main/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/mainscripts").Include(
                "~/Content/Scripts/Public.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/Main/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Styles/Fonts/VazirFonts.css",
                      "~/Content/Styles/Public.css"));
        }
    }
}
