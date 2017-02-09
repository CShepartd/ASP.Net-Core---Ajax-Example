using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_Ajax_Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult Ajax()
        {
            ViewData["Message"] = "Ajax Example";

            return View();
        }

        [HttpPost]
        public IActionResult Ajax(string name1, string name2)
        {
            ViewData["Message"] = "Ajax Example";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
