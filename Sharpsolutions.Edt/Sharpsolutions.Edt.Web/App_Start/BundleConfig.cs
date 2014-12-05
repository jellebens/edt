using Sharpsolutions.Edt.Web.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Sharpsolutions.Edt.Web {
    public static class BundleConfig {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            AddScripts(bundles);
            AddStyles(bundles);
        }

        private static void AddScripts(BundleCollection bundles) {

            bundles.Add(new ScriptBundle(Bundles.Scripts.JQuery)
                                                    .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.Bootstrap)
                                                    .Include("~/Scripts/bootstrap.js"));


            bundles.Add(new ScriptBundle(Bundles.Scripts.AngularJs)
                                                    .Include("~/Scripts/angular.js")
                                                    .Include("~/Scripts/angular-*")
                                                    .Include("~/Scripts/loading-bar.js")
                                                    );

            bundles.Add(new ScriptBundle(Bundles.Scripts.MetisMenu)
                                    .IncludeDirectory("~/Scripts/plugins/metisMenu", "*.js"));
            bundles.Add(new ScriptBundle(Bundles.Scripts.Pace)
                                    .IncludeDirectory("~/Scripts/plugins/pace", "*.js"));
            bundles.Add(new ScriptBundle(Bundles.Scripts.SlimScroll)
                                    .IncludeDirectory("~/Scripts/plugins/slimscroll", "*.js"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.Inspinia)
                                    .Include("~/Scripts/inspinia.js"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.EdtApp)
                .Include("~/app/app.js")
                .Include("~/app/config.js")
                .Include("~/app/inspinia-directives.js")
                .IncludeDirectory("~/app/directives/", "*.js")
                .IncludeDirectory("~/app/services/", "*.js")
                .IncludeDirectory("~/app/controllers/", "*.js")
                .Include("~/app/services.js")
                 );

            bundles.Add(new ScriptBundle(Bundles.Scripts.AppInsights).Include("~/Scripts/edt-appinsights.js"));
        }

        private static void AddStyles(BundleCollection bundles) {
            bundles.Add(new StyleBundle(Bundles.Styles.Common)
                                                        .Include("~/Content/footer.css")
                                                        .Include("~/Content/site.css"));

            bundles.Add(new StyleBundle(Bundles.Styles.Inspinia)
                                                    .Include("~/Content/bootstrap.css")
                                                    .Include("~/Content/animate.css")
                                                    .Include("~/Content/style.css")
                                                    .Include("~/Content/loading-bar.css")
                                                    .IncludeDirectory("~/Content/font-awesome/css", "*.css")
                                                    .Include("~/Content/bootstrap-overides.css")
                                                    .IncludeDirectory("~/Content/plugins/iCheck", "*.css")
                                                    );

        }
    }
}