using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesRecipe.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new HashSet<Ingredient>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public string Meal { get; set; }
        public string Information { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
