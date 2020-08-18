using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aula06HttpVerbs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("menu_inicial");
        }
        [HttpGet("home/novo_cliente")]
        public IActionResult Novo_cliente()
        {
            return View(); 
        }
        [HttpPost("home/novo_cliente")]
        public string novo_cliente_gravar()
        {
            return "Novo cliente gravado com sucesso.";
        }
    }
}