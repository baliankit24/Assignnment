using System.Collections.Generic;
using System.Linq;
using Assginment.Helpers;
using Assignment.Controllers;
using Assignment.Data;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Test
{
    [TestClass]
    public class ProductsContollerTestCases
    {
        private ApplicationDbContext _context;
        private ProductsController _pController;

        public ProductsContollerTestCases()
        {
            _context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Products").Options);
            _pController = new ProductsController(_context);
        }

        [TestMethod]
        public void CheckProductList()
        {
            string cereal = "Almond Delight";
            var result = _pController.Get(cereal).Value;
            Assert.IsTrue(result.Count() == 1, $"Count received {result.Count()} which is more than 1 record found");
            Assert.IsTrue(result.FirstOrDefault().name.Equals(cereal));
        }
    }
}
