using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assginment.Helpers;
using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ManufacturersController(ApplicationDbContext context)
        {
            _context = JsonHelper.LoadContext(context);
        }

        // GET api/Manufacturers/5
        [HttpGet]
        public ActionResult<IEnumerable<Manufacturer>> GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.Manufacturers;
            }
            else
            {
                return _context.Manufacturers.Where(x => x.ManufacturerName.Contains(name)).ToList();
            }
        }

        [HttpGet]
        public ActionResult<int> GetProductCount(string manufacturerName)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(manufacturerName))
            {
                var currentMfr = _context.Manufacturers.Where(x => x.ManufacturerName.Equals(manufacturerName)).FirstOrDefault().Mfr;
                if (!string.IsNullOrEmpty(currentMfr) && _context.Products != null && _context.Products.Count() > 0)
                {
                    count = _context.Products.Where(x => x.mfr.Equals(currentMfr)).Count();
                }
            }
            return count;
        }
    }
}
