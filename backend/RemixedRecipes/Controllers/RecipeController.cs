using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RemixedRecipes.Models;

namespace RemixedRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public RecipeController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object Get()
        {
            return _context.Recipes.Where(r => r.RecipeName.Contains("Recipe")).Select((s) => new
            {
                Id = s.Id,
                RecipeName = s.RecipeName,
                InstructionsId = s.InstructionsId
            }).ToList();
        }
    }
}
