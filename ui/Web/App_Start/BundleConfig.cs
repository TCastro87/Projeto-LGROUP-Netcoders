using System.Web.Optimization;

namespace Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //adicionamos bundles de estilo
            bundles.Add(new StyleBundle("~/CSS/styles").Include(
                    "~/Content/bootstrap.min.css",
                    "~/Content/bootstrap.theme.flaty.min.css",
                    "~/Content/Site.css"
                ));

            //adicionamos
            bundles.Add(new ScriptBundle("~/JS/scripts").Include(
                "~/scripts/jquery-3.1.0.min.js",
                "~/scripts/jquery-ui-1.12.0.min.js",
                "~/scripts/jquery.validate.min.js",
                "~/scripts/jquery.validate.unobtrusive.min.js",
                "~/scripts/jquery.maskedinput.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/scripts/modernizr-2.8.3.js",
                "~/scripts/app.js"
                ));

            // essa é a linha magica! e o que faz a minificação dos bundles
            // adicionados
            BundleTable.EnableOptimizations = true;
        }
    }
}