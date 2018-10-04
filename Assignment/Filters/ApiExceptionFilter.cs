using System;
using System.Collections.Generic;
using Assginment.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Serilog;

namespace Assginment.Filters
{
    class ApiExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            string message = $"Exception : {DateTime.Now} - {context.Exception.ToString()}";
            var log = LogHelper.GetLogInstance();
            log.Error(message);
            var values = new Dictionary<string, string> {
                { "action", "Error" },
                { "controller", "Home" },
                {"message" , message} };
            context.Result = new RedirectToRouteResult(new RouteValueDictionary(values));
            base.OnException(context);
        }
    }
}