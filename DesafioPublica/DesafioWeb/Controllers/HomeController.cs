using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioWeb.Models;
using DesafioCore.DB;
using DesafioCore.DB.Model;
using DesafioCore.RegraDeNegocio.Validacoes;

namespace DesafioWeb.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ManipuladorSqLite manipulador;
        public HomeController()
        {
            manipulador = new ManipuladorSqLite();
        }

        [HttpPost]
        public JsonResult Cadastrar([FromBody] JogoPlacar novoPlacar)
        {
            // Aqui ele irá verificar todos os validadores / Ver se existe mensagem de erro / Por fim ira cadastrar

            var validadores = new RegrasDeValidacaoFactory().ObterValidadoresJogoPlacar();
            var mensagemDeErro = validadores.Select(v => v.Validar(novoPlacar)).Where(r => !r.Valido).Select(r => r.Mensagem).ToArray();
            if(mensagemDeErro.Length > 0)
            {
                var msg = String.Join(';', mensagemDeErro);
                return Json(msg);
            }

            manipulador.AdicionarPlacar(novoPlacar);
            return Json("");
        }

        [HttpPost]
        public JsonResult Paginar([FromBody] Paginador paginador)
        {
            const int registrosPorPagina = 25;
            var contador = manipulador.Paginar();
            contador.Pular((paginador.Pagina - 1) * registrosPorPagina).Pegar(registrosPorPagina);
            var resultado = new PaginadorResultado();
            resultado.JogoPlacares = contador.Executar().ToList();
            resultado.TotalRegistros = contador.Contar();

            return Json(resultado);
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
