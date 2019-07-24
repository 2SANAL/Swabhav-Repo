using System;
using System.IO;
using System.Web.Mvc;

namespace DepartmentMvcApp.Filter
{
    public class LoggerFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string path = @"E:\SwabhavTech\EntityFramework\DepartmentMvcApp\Logger.txt";

            File.AppendAllText(path, filterContext.ActionDescriptor.ActionName + @" is perform  " +
                                     filterContext.ActionDescriptor.ControllerDescriptor.ControllerName +
                                     @" Controller" + Environment.NewLine);
            base.OnActionExecuting(filterContext);

        }

    }
}