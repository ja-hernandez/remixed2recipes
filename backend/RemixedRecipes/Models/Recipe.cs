using RemixedRecipes.Models;

public class Recipe {
    public int Id { get; set; }
    public string Name {get; set;}
    public Instructions Instructions { get; set; }
    public int InstructionsId {get; set; }
}