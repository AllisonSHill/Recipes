using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesRecipe.Data;
using RazorPagesRecipe.Models;

namespace RazorPagesRecipe.Pages.Ingredients
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRecipe.Data.RazorPagesRecipeContext _context;

        public IndexModel(RazorPagesRecipe.Data.RazorPagesRecipeContext context)
        {
            _context = context;
        }

        public IList<Ingredient> Ingredient { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public List<SelectListItem> recipeList { get; set; }

        public async Task OnGetAsync()
        {
            var ingredients = from i in _context.Ingredient
                          select i;
            if (!string.IsNullOrEmpty(SearchString))
            {
                ingredients = ingredients.Where(s => s.Name.Contains(SearchString));
            }
            Ingredient = await ingredients.ToListAsync();
        }
    }
}
