using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesRecipe.Models;

namespace RazorPagesRecipe.Data
{
    public class RazorPagesRecipeContext : DbContext
    {
        public RazorPagesRecipeContext (DbContextOptions<RazorPagesRecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }

        public DbSet<Ingredient> Ingredient { get; set; }
    }
}
