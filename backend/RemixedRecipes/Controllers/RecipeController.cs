using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        // GET: api/Recipe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recipe>>> Get()
        {
            return _context.Recipes.ToList();
        }

        // GET: api/Recipe/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Recipe>> Get(int id)
        {
            var selectedRecipe = await _context.Recipes.FindAsync(id);
            if (selectedRecipe == null)
            {
                return NotFound();
            }
            return selectedRecipe;
        }

        //// POST: api/Recipe
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Recipe/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var selectedRecipe = await _context.Recipes.FindAsync(id);
            if (selectedRecipe == null)
            {
                return NotFound();
            }
            _context.Recipes.Remove(selectedRecipe);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
