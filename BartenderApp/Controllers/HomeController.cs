using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Menu(string message)
        {
            ViewBag.TheMessage = "Your order has been placed";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Thanks for your feedback!";

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
