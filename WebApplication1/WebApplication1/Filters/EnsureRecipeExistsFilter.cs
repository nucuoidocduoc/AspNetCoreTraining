using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Filters
{
    public class EnsureRecipeExistsFilter : IActionFilter
    {
        private readonly RecipeService _recipeService;

        public EnsureRecipeExistsFilter(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = (int)context.ActionArguments["id"];
            if (!_recipeService.DoesRecipeExist(id)) {
                context.Result = new NotFoundResult();
            }
        }
    }
}