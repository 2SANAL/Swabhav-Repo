using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayEmployeeDetails.Servies;
using System.Web.Routing;

namespace DisplayEmployeeDetails
{
    public class MvcApplication : System.Web.HttpApplication
    {
      
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
       
        }
    }
}
