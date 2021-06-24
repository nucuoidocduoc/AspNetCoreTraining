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
    public class RecipeEnsureExist : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var service = (RecipeService)context.HttpContext.RequestServices.GetService(typeof(RecipeService));
            var recipeId = (int)context.ActionArguments["id"];
            if (!service.DoesRecipeExist(recipeId)) {
                context.Result = new NotFoundResult();
            }
        }
    }
}