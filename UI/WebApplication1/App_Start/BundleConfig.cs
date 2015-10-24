using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bottomscripts").Include(
                //"~/bower_components/jquery/dist/jquery.min.js",
                "~/bower_components/bootstrap/dist/js/bootstrap.min.js",
                "~/bower_components/metisMenu/dist/metisMenu.min.js",
                //"~/bower_components/raphael/raphael-min.js",
                //"~/bower_components/morrisjs/morris.js",
                //"~/Scripts/morris-data.js",
                "~/Scripts/sb-admin-2.js",
                "~/bower_components/jquery-validation/jquery.validate.js",
                 "~/bower_components/jquery-validation/jquery.validate.unobtrusive.js",
                 "~/bower_components/jquery-validation/localization/messages_tr.js",
                 "~/Scripts/CustomScripts.js"
                ));
            bundles.Add(new ScriptBundle("~/topscripts").Include(
                 "~/bower_components/jquery/dist/jquery.min.js",
                 "~/Scripts/TopCustomScripts.js"
                 
                ));
            bundles.Add(new StyleBundle("~/styles").Include(
                "~/bower_components/bootstrap/dist/css/bootstrap.css",
                "~/bower_components/bootstrap-social/bootstrap-social.css",
                "~/bower_components/metisMenu/dist/metisMenu.css",
                //"~/Context/timeline.css",
                "~/Context/sb-admin-2.css",
                //"~/bower_components/morrisjs/morris.css",
                "~/bower_components/font-awesome/css/font-awesome.min.css",
                "~/Context/hint.css"
                ));
            //BundleTable.EnableOptimizations = true;
        }
    }
}
