using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DiagnostisktProvProjekt.Models.ProductViewModels
{
    public class CreateEditProductViewModel
    {
        public Product Product { get; set; }
        public List<SelectListItem> AllProductCategories { get; set; }
        public int SelectedProductCategoryId { get; set; }
    }
}
