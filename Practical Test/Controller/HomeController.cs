using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practical_Test
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Name, string PhoneNo, string Address, string CreatedAt)
        {
            return Content($"Hello {Name}\n"+ $"Your phone number is {PhoneNo}\n"+ $"Your address is {Address}\n"+ $"Your Create At {CreatedAt}\n");
        }
    }
}