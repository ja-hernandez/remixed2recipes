using System;
using Microsoft.EntityFrameworkCore;
using RemixedRecipes.Maps;

namespace RemixedRecipes.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new RecipeMap(modelBuilder.Entity<Recipe>());
        }
    }
}
