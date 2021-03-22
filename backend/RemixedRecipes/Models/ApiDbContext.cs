using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RemixedRecipes.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Instructions> Instructions { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Preparation> Preparations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Instructions)
                .WithOne(i => i.Recipe)
                .HasForeignKey<Instructions>(r => r.RecipeId);

            //modelBuilder.Entity<Recipe>()
            //    .HasMany(r => r.Ingredients)
            //    .WithMany(i => i.Recipes)
            //    .UsingEntity<Dictionary<string, object>>(
            //    "RecipeIngredient",
            //    j => j
            //        .HasOne<Ingredient>()
            //        .WithMany()
            //        .HasForeignKey("IngredientId")
            //        .HasConstraintName("FK_RecipeIngredient_Ingredient_Id")
            //        .OnDelete(DeleteBehavior.Cascade)
            //        );




            
        }
    }
}
