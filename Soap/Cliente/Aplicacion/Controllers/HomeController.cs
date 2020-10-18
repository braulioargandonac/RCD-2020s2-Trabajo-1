using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Models;
using Microsoft.Extensions.Logging;

namespace Aplicacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult verut(String RUT)
        {
            Soap.serviClient x = new Soap.serviClient();
            var r = x.validarut(RUT);
            ViewBag.rut = r;
            return View();
        }
        public IActionResult RUT()
        {
            return View();
        }
        [HttpPost]
        public IActionResult verpersona(String nom, String ap, String am, String s)
        {
            Soap.serviClient per = new Soap.serviClient();
            var p = per.convertirAmayuscula(nom,ap,am,s);
            ViewBag.per = p;
            return View();
        }
        public IActionResult PERSONA()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult integrantes()
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
