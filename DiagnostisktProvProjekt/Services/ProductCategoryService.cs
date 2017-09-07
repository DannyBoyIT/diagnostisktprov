using DiagnostisktProvProjekt.Data;
using DiagnostisktProvProjekt.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProvProjekt.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetProductCategories()
        {
            var selectListItem = _context.ProductCategories.ToList()
                                                                    .Select(i => new SelectListItem()
                                                                    {
                                                                        Text = i.Name,
                                                                        Value = i.ProductCategoryId.ToString()
                                                                    });

            return selectListItem;
        }
    }
}
