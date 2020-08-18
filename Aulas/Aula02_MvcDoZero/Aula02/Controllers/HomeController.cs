using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aula02.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public string nome { get; set; }
        // a strinn nome só fuinciona no viewdata, se for adicionado o Get e Set

        public IActionResult Index() // metodo
        {
            Cliente novo = new Cliente() { //criando um objeto
                Nome = "Cinthia",
                Apelido ="Barbosa",
                Telefone="4555-5222"
            };
            return View(novo); // retorna a View
        }
        public IActionResult pag1()
        {
            //ultilizar uma viewBag
            //ViewBag.mensagem1 = "Essa é a mensagem 1 para a pagina 01";
            //ViewBag.mensagem2 = "Essa é a mensagem 2 para a pagina 01";
            return View();
        }
        public IActionResult pag2()
        {
            //usando o viewData
            //ViewData["Nome"] = "Joao";
            //ViewData["Apelido"] = "Ribeiro";

            return View();
        }
        public IActionResult pag3()
        {
            nome = "joao";
            return View();
        }
    }
}