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
                 .IncludeDirectory("~/app/services/", "*.js")
                 .IncludeDirectory("~/app/controllers/", "*.js")
                 .Include("~/app/sharpsolutions-edt.js"));


        }

        private static void AddStyles(BundleCollection bundles) {
            bundles.Add(new StyleBundle(Bundles.Styles.Common)
                                                    .Include("~/Content/site.css")
                                                    );

            bundles.Add(new StyleBundle(Bundles.Styles.Bootstrap)
                                                    .Include("~/Content/bootstrap.css"));
        }
    }
}