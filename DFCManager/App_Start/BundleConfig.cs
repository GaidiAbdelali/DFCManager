using System.Web;
using System.Web.Optimization;

namespace DFCManager
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            //js
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jQuery-2.2.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/custom/app.js",
                        "~/Scripts/custom/dashboard2.js",
                        "~/Scripts/custom/demo.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                        "~/Scripts/plugins/fastclick/fastclick.js",
                        "~/Scripts/plugins/sparkline/jquery.sparkline.min.js",
                        "~/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js",
                        "~/Scripts/plugins/chartjs/Chart.min.js"));

            //css
            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include("~/Content/bootstrap/css/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/custom/css").Include("~/Content/custom/template-style.min.css"));
            
           
        }
    }
}