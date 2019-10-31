using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecipe.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Instructions { get; set; }
        public string recipeName { get; set; }
        [Required]
        public int RecipeID { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
