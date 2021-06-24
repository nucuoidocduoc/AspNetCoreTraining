using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Filters
{
    public class EnsureRecipeExist : TypeFilterAttribute
    {
        public EnsureRecipeExist() : base(typeof(EnsureRecipeExistsFilter))
        {
        }
    }
}