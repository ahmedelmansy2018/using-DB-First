using HopeUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HopeUniversity
{
    public class MvcApplication : System.Web.HttpApplication
    {
        HopeUniversityEntities db = new HopeUniversityEntities();
        protected void Application_Start()
        {

            db.Database.CreateIfNotExists();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
