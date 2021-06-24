using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("./Views/Home/CreateUser.cshtml", new UserBindingModel() { FirstName = "123", LastName = "456" });
        }

        [HttpPost]
        public IActionResult CreateUser(UserBindingModel user)
        {
            if (!ModelState.IsValid) {
                return View(user);
            }
            return RedirectToAction(nameof(Success));
        }

        [HttpGet]
        public ViewResult Success()
        {
            return View();
        }
    }
}