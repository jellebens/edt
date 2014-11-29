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

            bundles.Add(new ScriptBundle(Bundles.Scripts.EdtApp)
                .Include("~/app/app.js") 
                .IncludeDirectory("~/app/services/", "*.js")
                 .IncludeDirectory("~/app/controllers/", "*.js")
                 .Include("~/app/services.js")
                 .Include("~/app/config.js"));
        }

        private static void AddStyles(BundleCollection bundles) {
            bundles.Add(new StyleBundle(Bundles.Styles.Common)
                                                    .Include("~/Content/site.css")
                                                    );

            bundles.Add(new StyleBundle(Bundles.Styles.Inspinia)
                                                    .Include("~/Content/bootstrap.css")
                                                    .Include("~/Content/animate.css")
                                                    .Include("~/Content/style.css")
                                                    .IncludeDirectory("~/Content/font-awesome/css", "*.css")
                                                    .Include("~/Content/bootstrap-overides.css"));

        }
    }
}