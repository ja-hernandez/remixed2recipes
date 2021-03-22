using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RemixedRecipes.Models;

public class Recipe {
    [Key]
    public int Id { get; set; }
    public string Name {get; set;}
    public Instructions Instructions { get; set; }

    public ICollection<Ingredient> Ingredients { get; set; }

    public List<RecipeIngredient> RecipeIngredients { get; set; }
}