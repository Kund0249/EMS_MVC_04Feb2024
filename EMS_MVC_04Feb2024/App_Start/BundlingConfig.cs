using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace EMS_MVC_04Feb2024
{
    public class BundlingConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            //--------Add All Script-------------
            var bundle = new ScriptBundle("~/bundle/JS");

            bundle.Include("~/Content/JS/JavaScript1.js",
                "~/Content/JS/JavaScript2.js",
                "~/Content/JS/JavaScript3.js");
            bundles.Add(bundle);

            //--------Add All Style-------------
            //var stylebundle = new StyleBundle("~/bundle/CSS");
            //stylebundle.Include("~/Content/css/bootstrap.css");
            //bundles.Add(stylebundle);


            BundleTable.EnableOptimizations = true;
        }
    }
}