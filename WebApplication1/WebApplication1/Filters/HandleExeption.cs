using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Filters
{
    public class HandleExeption : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var error = new {
                Success = false,
                Errors = new[] { context.Exception.Message }
            };
            context.Result = new ObjectResult(error) {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}