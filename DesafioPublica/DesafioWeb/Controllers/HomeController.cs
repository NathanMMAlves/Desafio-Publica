using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioWeb.Models;
using DesafioCore.DB;

namespace DesafioWeb.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ManipuladorSqLite manipulador;
        public HomeController()
        {
            manipulador = new ManipuladorSqLite();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult Placar()
        {
            return View();
        }

       
        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private readonly ILogger<HomeController> _logger;
        public IActionResult Index()
        {
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
        */
    }
}
