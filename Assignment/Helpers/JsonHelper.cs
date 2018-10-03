using System.Linq;
using Assignment.Data;
using Assignment.Models;

namespace Assginment.Helpers
{
    public class JsonHelper
    {
        public static ApplicationDbContext LoadContext(ApplicationDbContext dbContext)
        {
            if (dbContext.Products.Count() == 0 || dbContext.Manufacturers.Count() == 0)
            {
                dbContext.Products.AddRange(FileHelper<Product>.ReadJsonNodes(Constants.ConstValues.FilePathProducts));
                dbContext.Manufacturers.AddRange(FileHelper<Manufacturer>.ReadJsonNodes(Constants.ConstValues.FilePathManufacturers));
                dbContext.SaveChanges();
            }
            return dbContext;
        }
    }

  
}
