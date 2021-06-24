using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class RecipeService
    {
        public bool DoesRecipeExist(int id)
        {
            return id > 0;
        }
    }
}