using System.Collections.Generic;
using System.IO;
using System.Linq;
using Assignment.Data;
using Assignment.Models;
using Newtonsoft.Json;

namespace Assginment.Helpers
{
    public class JsonHelper
    {
        private static List<Product> GetProductListFromJson()
        {
            string filePath = @"D:\My\Projects\VsCode\Assignment\Assignment\App_Data\Products.json";
            var products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(filePath));
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                var movie2 = (List<Product>)serializer.Deserialize(file, typeof(List<Product>));
            }
            return products;
        }

        private static List<Manufacturer> GetManufacturersFromJson()
        {
            string filePath = @"D:\My\Projects\VsCode\Assignment\Assignment\App_Data\Maufacturer.json";
            var manufacturers = JsonConvert.DeserializeObject<List<Manufacturer>>(File.ReadAllText(filePath));

            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                var movie2 = (List<Manufacturer>)serializer.Deserialize(file, typeof(List<Manufacturer>));
            }
            return manufacturers;
        }

        // private static List<T> GetJson(string filePath)        
        // {
        //     var resultList = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filePath));
        //     // using (StreamReader file = File.OpenText(filePath))
        //     // {
        //     //     JsonSerializer serializer = new JsonSerializer();
        //     //     var resultList = (List<Product>)serializer.Deserialize(file, typeof(List<Product>));
        //     // }
        //     return resultList;

        // }

        public static ApplicationDbContext LoadContext(ApplicationDbContext dbContext)
        {
            if (dbContext.Products.Count() == 0 || dbContext.Manufacturers.Count() == 0)
            {
                dbContext.Products.AddRange(JsonHelper.GetProductListFromJson());
                dbContext.Manufacturers.AddRange(JsonHelper.GetManufacturersFromJson());
                dbContext.SaveChanges();
            }
            return dbContext;
        }
    }
}
