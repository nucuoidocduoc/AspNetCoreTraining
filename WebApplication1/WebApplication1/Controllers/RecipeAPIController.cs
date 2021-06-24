using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Filters;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/recipe")]
    [FeatureEnabled(IsEnabled = true), ValidateModel, HandleExeption]
    public class RecipeAPIController : ControllerBase
    {
        private readonly RecipeService _recipeService;

        public RecipeAPIController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet("{id:int}")]
        [EnsureRecipeExist]
        public IActionResult Get(int id)
        {
            //if (!IsEnabled) {
            //    return BadRequest();
            //}
            //if (!ModelState.IsValid) {
            //    return BadRequest(ModelState);
            //}
            //try {
            //if (!_recipeService.DoesRecipeExist(id)) {
            //    return NotFound();
            //}
            Response.Headers.Add("123", "123");
            return Ok();
            //}
            //catch (Exception ex) {
            //    return GetErrorResponse(ex);
            //}
        }

        private static IActionResult GetErrorResponse(Exception ex)
        {
            var error = new {
                Success = false,
                Errors = new[] {
                    ex.Message
                }
            };
            return new ObjectResult(error) {
                StatusCode = 500
            };
        }
    }
}