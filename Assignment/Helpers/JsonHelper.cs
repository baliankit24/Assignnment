using System.Linq;
using Assginment.Constants;
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
                dbContext.Products.AddRange(FileHelper<Product>.ReadJsonNodes(ConstValues.FilePathProducts));
                dbContext.Manufacturers.AddRange(FileHelper<Manufacturer>.ReadJsonNodes(ConstValues.FilePathManufacturers));
                dbContext.SaveChanges();
            }
            return dbContext;
        }
    }


}
