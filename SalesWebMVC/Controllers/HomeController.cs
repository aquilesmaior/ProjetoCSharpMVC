using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

      
        public IActionResult About() {
            ViewData["Message"] = "Empresa ficticia X";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Central de atendimento";

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
