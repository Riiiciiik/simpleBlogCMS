using System.Web;
using System.Web.Optimization;

namespace SimpleBlogCMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/Content/styles/bootstrap.css")
                .Include("~/Content/styles/admin.css"));

            bundles.Add(new StyleBundle("~/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/admin/jquery")
                        .Include("~/scripts/jquery-{version}.js")
                        .Include("~/scripts/jquery.validate.js")
                        .Include("~/scripts/jquery.validate.unobtrusive.js")
                        .Include("~/scripts/bootstrap.js")
                        .Include("~/areas/admin/scripts/forms.js")
                        );

            bundles.Add(new ScriptBundle("~/scripts")
                        .Include("~/scripts/jquery-{version}.js")
                        .Include("~/scripts/jquery.validate*")
                        .Include("~/scripts/jquery.validate.unobtrusive.js")
                        .Include("~/scripts/bootstrap.js")
                        );

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //                             "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            
            
        }
    }
}
