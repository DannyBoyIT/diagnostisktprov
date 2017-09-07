using DiagnostisktProvProjekt.Data;
using DiagnostisktProvProjekt.Models;
using System.Linq;

namespace PizzaDeluxe.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context,)
        {
            if (!context.ProductCategories.Any())
            {
                var tv = new ProductCategory() { Name = "TV" };
                var dvd = new ProductCategory() { Name = "DVD" };
                var vhs = new ProductCategory() { Name = "VHS" };
            }
        }
    }
}
