﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Bursify.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Content/assets/js/jquery-1.11.1.min.js"));



            bundles.Add(new ScriptBundle("~/bundles/vendors").Include(
                "~/Scripts/Vendors/jquery.js",
                "~/Scripts/Vendors/bootstrap.js",
                "~/Scripts/Vendors/toastr.js",
                "~/Scripts/Vendors/jquery.raty.js",
                "~/Scripts/Vendors/respond.src.js",
                "~/Scripts/Vendors/angular.js",
                "~/Scripts/Vendors/angular-route.js",
                "~/Scripts/Vendors/angular-cookies.js",
                "~/Scripts/Vendors/angular-validator.js",
                "~/Scripts/Vendors/angular-base64.js",
                "~/Scripts/Vendors/angular-file-upload.js",
                "~/Scripts/Vendors/angucomplete-alt.min.js",
                "~/Scripts/Vendors/ui-bootstrap-tpls-0.13.1.js",
                "~/Scripts/Vendors/underscore.js",
                "~/Scripts/Vendors/raphael.js",
                "~/Scripts/Vendors/morris.js",
                "~/Scripts/Vendors/jquery.fancybox.js",
                "~/Scripts/Vendors/jquery.fancybox-media.js",
                "~/Scripts/Vendors/loading-bar.js",
                "~/Content/assets/js/jquery.ui.min.js",
                   "~/ Content/assets/js/main.js"

                /*
         *     <script src=></script>
<script src=></script>
<script src="~/Content/assets/js/plugins/select2.full.min.js"></script>

<!-- plugins -->
<script src="~/Content/assets/js/plugins/moment.min.js"></script>
<script src="~/Content/assets/js/plugins/jquery.knob.js"></script>
<script src="~/Content/assets/js/plugins/nouislider.min.js"></script>
<script src="~/Content/assets/css/plugins/rangeslider.js"></script>
<script src="~/Content/assets/css/plugins/rangeslider.min.js"></script>
<script src="~/Content/assets/js/plugins/fullcalendar.min.js"></script>
<script src="~/Content/assets/js/plugins/jquery.nicescroll.js"></script>
<script src="~/Content/assets/js/plugins/jquery.mask.min.js"></script>
<script src="~/Content/assets/js/plugins/jquery.validate.min.js"></script>

         */
                ));

            bundles.Add(new ScriptBundle("~/bundles/spa").Include(
                "~/Scripts/spa/modules/common.core.js",
                "~/Scripts/spa/modules/common.ui.js",
                "~/Scripts/spa/app.js",
                "~/Scripts/spa/services/apiService.js",
                "~/Scripts/spa/services/notificationService.js",
                "~/Scripts/spa/services/membershipService.js",
                "~/Scripts/spa/services/fileUploadService.js",
                "~/Scripts/spa/account/loginCtrl.js",

                "~/Scripts/spa/account/registerCtrl.js",
                "~/Scripts/spa/home/rootCtrl.js",
                "~/Scripts/spa/home/indexCtrl.js",
                "~/Scripts/spa/bursify/student/home/studentCtrl.js",
                "~/Scripts/spa/bursify/admin/home/adminCtrl.js",
                "~/Scripts/spa/bursify/sponsor/home/sponsorCtrl.js",
                 "~/Scripts/spa/layout/navBar.directive.js"

        
                
                ));
            

      

            bundles.Add(new StyleBundle("~/Content/css").Include(
               
                "~/content/css/bootstrap.css",
               
                 "~/content/css/font-awesome.css",
                "~/content/css/morris.css",
                "~/content/css/toastr.css",
                "~/content/css/jquery.fancybox.css",
                "~/content/css/loading-bar.css",
                "~/content/assets/css/style.css",
                "~/content/dist/css/AdminLTE.min.css",
                "~/Content/assets/css/jquery.steps.css"

                ));



       
            BundleTable.EnableOptimizations = false;
        }
    }
}
 