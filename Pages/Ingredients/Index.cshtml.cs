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
        public SelectList RecipeNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedRecipe { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> recipeQuery = from i in _context.Ingredient
                                           orderby i.recipeName
                                           select i.recipeName;

            var ingredients = from i in _context.Ingredient
                          select i;
            if (!string.IsNullOrEmpty(SearchString))
            {
                ingredients = ingredients.Where(s => s.Name.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(SelectedRecipe))
            {
                ingredients = ingredients.Where(x => x.recipeName == SelectedRecipe);
            }
            RecipeNames = new SelectList(await recipeQuery.Distinct().ToListAsync());
            Ingredient = await ingredients.ToListAsync();
        }
    }
}
