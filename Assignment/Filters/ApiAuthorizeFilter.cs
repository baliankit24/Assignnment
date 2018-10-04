using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Assginment.Filters
{
    class ApiAuthorizeFilter : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Authorization can be added as per requirement.
            //context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
            return;
        }
    }
}