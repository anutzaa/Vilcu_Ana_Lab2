using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vilcu_Ana_Lab2.Data;
using Vilcu_Ana_Lab2.Migrations;
using Vilcu_Ana_Lab2.Models;
using Vilcu_Ana_Lab2.Models.ViewModels;

namespace Vilcu_Ana_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Vilcu_Ana_Lab2.Data.Vilcu_Ana_Lab2Context _context;

        public IndexModel(Vilcu_Ana_Lab2.Data.Vilcu_Ana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }


        public async Task OnGetAsync(int? id, int? BookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
            .Include(c => c.BookCategories)
            .ThenInclude(bc => bc.Book)
            .ThenInclude(b => b.Author)
            .OrderBy(c => c.CategoryName)
            .ToListAsync();
            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                .Where(c => c.ID == id.Value).Single();
                CategoryData.Books = category.BookCategories.Select(bc => bc.Book);
            }


            /*if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }*/
        }
    }
}
