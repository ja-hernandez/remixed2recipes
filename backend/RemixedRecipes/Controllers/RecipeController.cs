using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RemixedRecipes.Models;

namespace RemixedRecipes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public RecipeController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> Get()
        {
            return _context.Recipes.ToList();
        }
    }
}
