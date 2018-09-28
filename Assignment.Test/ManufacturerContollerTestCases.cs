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
    public class ManufacturerContollerTestCases
    {
        private ApplicationDbContext _context;
        private ManufacturersController _mnController;

        public ManufacturerContollerTestCases()
        {
            _context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("Products").Options);
            _mnController = new ManufacturersController(_context);
        }

        [TestMethod]
        public void CheckGetByNameMethodCount()
        {
            var resultList = _mnController.GetByName(null).Value;
            Assert.IsTrue(resultList.Count() == 7, "Total manufacturer count does not matches");
        }

        [TestMethod]
        public void CheckGetByNameMethodValue()
        {
            string mnName = "American Home Food Products";
            string mnMfr = "A";
            string mnStockSymbol = "AHFP";
            var result = _mnController.GetByName(mnName).Value;

            Assert.IsTrue(result.Count() == 1, "Count not equal to 1");
            Assert.IsTrue(result.FirstOrDefault().ManufacturerName.Equals(mnName), "Name does not matches");
            Assert.IsTrue(result.FirstOrDefault().Mfr.Equals(mnMfr), "MFR does not matches");
            Assert.IsTrue(result.FirstOrDefault().StockSymbol.Equals(mnStockSymbol), "Stock symbol does not matches");
        }

        [TestMethod]
        public void CheckGetProductCount()
        {
            string mnName = "American Home Food Products";
            var result = _mnController.GetProductCount(mnName).Value;
            Assert.IsTrue(result == 1, $"Count of products {result} does not matches 7 for - American Home Food Products");
        }
    }
}
