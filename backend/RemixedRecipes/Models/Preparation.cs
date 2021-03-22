using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RemixedRecipes.Models
{
    public class Preparation
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Recipe> Recipes { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }

        public Preparation()
        {
        }
    }
}
