using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class FruitController
    {
        [Route("")]
        public IEnumerable<string> Index()
        {
            return new List<string> {
                "Pear",
                "Lemon",
                "Peach"
            };
        }
    }
}