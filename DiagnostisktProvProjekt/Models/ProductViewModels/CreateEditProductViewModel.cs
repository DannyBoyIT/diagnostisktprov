using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProvProjekt.Models.ProductViewModels
{
    public class CreateEditProductViewModel
    {
        public Product Product { get; set; }
        public List<ProductCategory> AllProductCategories { get; set; }
    }
}
