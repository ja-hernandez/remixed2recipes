using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RemixedRecipes.Maps
{
    public class RecipeMap
    {
        public RecipeMap(EntityTypeBuilder<Recipe> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("recipe");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.RecipeName).HasColumnName("recipe_name");
            entityBuilder.Property(x => x.InstructionsId).HasColumnName("instructions_id");
            
        }
    }
}
