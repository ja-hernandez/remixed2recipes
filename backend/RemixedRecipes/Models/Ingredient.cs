using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemixedRecipes.Models
{
    public class Ingredient
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //public ICollection<Recipe> Recipes { get; set; }
        //public List<RecipeIngredient> RecipeIngredients { get; set; }

        public Ingredient()
        {
        }
    }
}
