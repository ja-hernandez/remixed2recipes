using System;
namespace RemixedRecipes.Models
{
    public class RecipeIngredient
    {
        public Recipe Recioe { get; set; }
        public int RecipeId { get; set; }
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        public Quantity Quantity { get; set; }
        public int QuantityId { get; set; }
        public Unit Unit { get; set; }
        public int UnitId { get; set; }
        public Preparation Preparation { get; set; }
        public RecipeIngredient()
        {
        }
    }
}
