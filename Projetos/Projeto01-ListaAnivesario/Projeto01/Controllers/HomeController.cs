using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto01.Models;

namespace Projeto01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Inicio");
        }
        [HttpGet]
        public ViewResult Formulario()
        {
            return View("Formulario");
        }

        [HttpPost]
        public ViewResult Formulario(RespostaConvidados resposta)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("Obrigado",resposta);
        }
        public ViewResult ListaConvidados()
        {
            return View("Listafinal",Repositorio.ListaFinal.Where(c => c.Presente == true));
        }
    }
}
