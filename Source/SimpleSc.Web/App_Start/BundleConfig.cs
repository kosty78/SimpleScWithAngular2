using System.Web.Optimization;

namespace SimpleSc.Web
{
    public class BundleConfig 
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterJs(bundles);
            RegisterCss(bundles);
        }

        static void RegisterJs(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include("~/Static/scripts/vendor/jquery/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include("~/Static/scripts/vendor/bootstrap/bootstrap.js"));
        }

        static void RegisterCss(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include("~/Static/css/vendor/bootstrap/bootstrap.css"));
            bundles.Add(new StyleBundle("~/bundles/css/custom").Include("~/Static/css/style.css"));
        }
    }
}