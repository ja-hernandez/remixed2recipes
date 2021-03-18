using System;
using Microsoft.EntityFrameworkCore;
using RemixedRecipe.Models;

namespace RemixedRecipe
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
