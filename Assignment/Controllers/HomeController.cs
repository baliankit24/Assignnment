using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "Api started!!!";
        }

        [HttpGet]
        public ActionResult<string> Error(string message)
        {
            return $"Something went wrong : {message}";
        }
    }

}