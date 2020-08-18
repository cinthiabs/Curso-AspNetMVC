using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoCRUDCarros.Models;

namespace ProjetoCRUD_Carros.Controllers
{
    public class CarrosController : Controller
    {
        private readonly Contexto _contexto; // inserindo o contexto no controller

        public CarrosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View(_contexto.Carros.ToList()); //mostra os registros da tabela na index
        }

        [HttpGet]
        public IActionResult NovoCarro()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NovoCarro(Carro carro)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(carro);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));

                
            }
            return View(carro);
        }
        [HttpGet] // pegar as informações
        public IActionResult AtualizarCarro(int? id)
        {
            if (id == null) //se o id for nulo
            {
                return NotFound();

            }
            else
            {
                var carro = _contexto.Carros.Find(id);
                return View(carro);
            }
        }
        [HttpPost] // atualizar as informacoes
        [ValidateAntiForgeryToken]
        public IActionResult AtualizarCarro(int? id, Carro carro)
        {
            if(id == null)
            {
                return NotFound();
            }
            else if(ModelState.IsValid) // se os dados for valido
            {
                _contexto.Update(carro); // atualizar
                _contexto.SaveChanges(); // salvar

                return RedirectToAction(nameof(Index)); // apos atualizado, redirecionar para a pagina index
            }
            else
            {
                return View(carro);
            }
        }

        public IActionResult Detalhes(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            else
            {
                var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId == id);

                return View(carro);
            }
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId == id);

                return View(carro);
            }

        }

             [HttpPost, ActionName("Excluir")]
             [ValidateAntiForgeryToken]
            public IActionResult ConfirmarExclusao(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                else
                {
                    var carro = _contexto.Carros.FirstOrDefault(x => x.CarroId == id);
                    _contexto.Remove(carro); // excluir registro
                    _contexto.SaveChanges(); // salvar alteração
                    return RedirectToAction(nameof(Index));
                }
            }

    }
}