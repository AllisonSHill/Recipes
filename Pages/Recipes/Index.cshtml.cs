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

namespace RazorPagesRecipe.Pages.Recipes
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesRecipe.Data.RazorPagesRecipeContext _context;

        public IndexModel(RazorPagesRecipe.Data.RazorPagesRecipeContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Meals { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedMeal { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> mealQuery = from r in _context.Recipe
                                           orderby r.Meal
                                           select r.Meal;

            var recipes = from r in _context.Recipe
                          select r;
            if (!string.IsNullOrEmpty(SearchString))
            {
                recipes = recipes.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(SelectedMeal))
            {
                recipes = recipes.Where(x => x.Meal == SelectedMeal);
            }
            Meals = new SelectList(await mealQuery.Distinct().ToListAsync());
            Recipe = await recipes.ToListAsync();
        }
    }
}
