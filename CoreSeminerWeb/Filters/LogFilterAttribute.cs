using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSeminerWeb
{
    public class LogFilterAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string log = $"{DateTime.Now.ToString()}: {context.ActionDescriptor.DisplayName}\r\n";
            System.IO.File.AppendAllText("D:\\seminer.log", log);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}
