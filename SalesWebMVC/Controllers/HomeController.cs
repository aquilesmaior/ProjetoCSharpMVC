using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Sobre() {
            ViewData["Message"] = "Descrição sobre essa empresa.";
            ViewData["Dev"] = "Aquiles Maior";

            return View();
        }

        public IActionResult Departamentos() {

            return View();
        }

        public IActionResult Contato() {
            ViewData["Message"] = "Página de Contatos.";

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
