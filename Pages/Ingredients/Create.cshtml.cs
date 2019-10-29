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
    public class CreateModel : PageModel
    {
        private readonly RazorPagesRecipe.Data.RazorPagesRecipeContext _context;

        public CreateModel(RazorPagesRecipe.Data.RazorPagesRecipeContext context)
        {
            _context = context;
        }
        public List<SelectListItem> recipeList { get; set; }
        public IActionResult OnGet()
        {
            recipeList = _context.Recipe.Select(r => new SelectListItem
            {
                Value = r.ID.ToString(),
                Text = r.Name
            }).ToList();
            return Page();
        }

        [BindProperty]
        public Ingredient Ingredient { get; set; }
        [BindProperty]
        public string RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int RecipeID)
        {
            Ingredient.RecipeID = RecipeID;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var specificRecipe = _context.Recipe.Find(RecipeID);
                Ingredient.Recipe = specificRecipe;
                _context.Ingredient.Add(Ingredient);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
            }

        }
    }
