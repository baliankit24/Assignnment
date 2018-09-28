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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = JsonHelper.LoadContext(context);
        }

        // GET api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get(
                                        string name = "",
                                        string minimumRating = "",
                                        string minimumFiberContent = "",
                                        string minimumProteinContent = "")
        {
            IEnumerable<Product> products = _context.Products;

            if (!string.IsNullOrWhiteSpace(name))
            {
                products = products.Where(x => x.name.Equals(name));
            }
            if (!string.IsNullOrEmpty(minimumRating))
            {
                products = products.Where(x => Convert.ToDecimal(x.rating) == Convert.ToDecimal(minimumRating));
            }
            if (!string.IsNullOrEmpty(minimumFiberContent))
            {
                products = products.Where(x => Convert.ToDecimal(x.fiber) == Convert.ToDecimal(minimumFiberContent));
            }
            if (!string.IsNullOrEmpty(minimumProteinContent))
            {
                products = products.Where(x => Convert.ToDecimal(x.protein) == Convert.ToDecimal(minimumProteinContent));
            }
            return products.ToList();
        }
    }
}
