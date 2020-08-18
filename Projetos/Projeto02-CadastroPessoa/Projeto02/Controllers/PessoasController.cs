using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto02.Models;

namespace Projeto02.Controllers
{
    public class PessoasController : Controller
    {
        private readonly Contexto _contexto;

        public  PessoasController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View( await _contexto.Pessoas.ToListAsync());
        }
        public IActionResult CriarPessoa()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> CriarPessoa(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(pessoa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(pessoa);
           
            }

        }
        [HttpGet] // metodo para atualizar registro
        public IActionResult AtualizarPessoa(int? id)
        {
            if(id != null)
            {
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View(pessoa);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]  // metodo para atualizar registro
        public  async Task<IActionResult>AtualizarPessoa(int? id,Pessoa pessoa)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                { // se as informações não validas 
                    _contexto.Update(pessoa);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }else
                {
                    return View(pessoa);
                }
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]// metodo para excluir registro
        public IActionResult ExcluirPessoa(int? id)
        {
            if (id != null)
            {
                Pessoa pessoa = _contexto.Pessoas.Find(id);
                return View(pessoa);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]// metodo para excluir registro
        public async Task<IActionResult>ExcluirPessoa(int? id, Pessoa pessoa)
        {
            if (id != null)
            {
                _contexto.Remove(pessoa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return NotFound();
            }
        }

    }
}