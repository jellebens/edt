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

            AddBootStrap(bundles);


            bundles.Add(new ScriptBundle(Bundles.Scripts.AngularJs)
                                                    .Include("~/Scripts/angular.js")
                                                    .Include("~/Scripts/angular-*")
                                                    .Include("~/Scripts/loading-bar.js")
                                                    );

            AddMetisMenu(bundles);
            AddPace(bundles);
            AddSlimScroll(bundles);
            AddDataTable(bundles);
            AddNgTable(bundles);

            bundles.Add(new ScriptBundle(Bundles.Scripts.Inspinia)
                                    .Include("~/Scripts/inspinia.js"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.EdtApp)
                .Include("~/app/app.js")
                .Include("~/app/config.js")
                .Include("~/app/inspinia-directives.js")
                .IncludeDirectory("~/app/directives/", "*.js")
                .IncludeDirectory("~/app/services/", "*.js")
                .IncludeDirectory("~/app/controllers/", "*.js")
                 );

            bundles.Add(new ScriptBundle(Bundles.Scripts.AppInsights).Include("~/Scripts/edt-appinsights.js"));
        }

        private static void AddNgTable(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Bundles.Scripts.NgTable)
                                    .Include("~/Scripts/ng-table.js"));

            bundles.Add(new StyleBundle(Bundles.Styles.NgTable)
                                    .Include("~/Scripts/ng-table.css"));
        }

        private static void AddDataTable(BundleCollection bundles) {
            bundles.Add(new ScriptBundle(Bundles.Scripts.DataTables)
                .Include("~/Scripts/plugins/angular-datatables.min.js")
                .Include("~/Scripts/plugins/jquery.dataTables.js")
                .Include("~/Scripts/plugins/dataTables.bootstrap.js"));

            bundles.Add(new StyleBundle(Bundles.Styles.DataTables)
                .IncludeDirectory("~/Content/plugins/dataTables","*.css"));
        }

        private static void AddBootStrap(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Bundles.Scripts.Bootstrap)
                .Include("~/Scripts/bootstrap.js"));
        }

        private static void AddPace(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Bundles.Scripts.Pace)
                .IncludeDirectory("~/Scripts/plugins/pace", "*.js"));
        }

        private static void AddMetisMenu(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Bundles.Scripts.MetisMenu)
                .IncludeDirectory("~/Scripts/plugins/metisMenu", "*.js"));
        }

        private static void AddSlimScroll(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Bundles.Scripts.SlimScroll)
                .IncludeDirectory("~/Scripts/plugins/slimscroll", "*.js"));
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