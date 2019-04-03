using System.Web;
using System.Web.Optimization;

namespace cv
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Prasmes").Include(
                      "~/Scripts/Prasmes.js"));
            bundles.Add(new StyleBundle("~/Prasmes/css").Include(
                      "~/Content/Prasmes.css"));

            bundles.Add(new StyleBundle("~/Izglitiba/css").Include(
                      "~/Content/Izglitiba.css"));

            bundles.Add(new ScriptBundle("~/bundles/VaditajaAplieciba").Include(
                     "~/Scripts/VaditajaAplieciba.js"));
            bundles.Add(new StyleBundle("~/VaditajaApliecibas/css").Include(
                      "~/Content/VaditajaAplieciba.css"));

            bundles.Add(new ScriptBundle("~/bundles/PersonasDati.js").Include(
                     "~/Scripts/PersonasDati.js"));
            bundles.Add(new StyleBundle("~/PersonasDati/css").Include(
                      "~/Content/PersonasDati.css"));

            bundles.Add(new StyleBundle("~/DarbaPieredze1/css").Include(
                      "~/Content/DarbaPieredze1.css"));

            bundles.Add(new StyleBundle("~/Valodas/css").Include(
                      "~/Content/Valodas.css"));

            bundles.Add(new ScriptBundle("~/bundles/MotivacijasVestule").Include(
                     "~/Scripts/MotivacijasVestule.js"));
            bundles.Add(new StyleBundle("~/MotivacijasVestule/css").Include(
                      "~/Content/MotivacijasVestule.css"));

        }
    }
}
