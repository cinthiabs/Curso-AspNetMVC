using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aula04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // criar um homem
            Humano homem = new Humano()
            {
                Nome = "Cinthia",
                Sobrenome = "Barbosa"
            };
            Automovel carro = new Automovel()
            {
                Marca = "Audi",
                Cor = "Metal"

            };
            // passando o a classe de informações juntas 
            InformacoesJuntas juntas = new InformacoesJuntas()
            {
                humano = homem,
                automovel = carro
            };
        
            return View(juntas); // passando o objeto para a view Index
        }
    }
}