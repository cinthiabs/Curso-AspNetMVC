using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMoeda.Models;

namespace ProjetoMoeda.Controllers
{
    public class MoedasController : Controller
    {
        private readonly MoedaContexto _context;

        public MoedasController(MoedaContexto context)
        {
            _context = context;
        }

        // GET: Moedas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Moedas.ToListAsync());
        }

        public async Task<IActionResult> EscolhadeMoedas(List<Moeda> moedas)
        {
            foreach(var item in moedas)
            {
                if (item.CheckboxMarcado == true)
                {
                    Moeda moeda = await _context.Moedas.FindAsync(item.MoedaId);
                    moeda.Quantidade = moeda.Quantidade + 1;
                    _context.Update(moeda);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public JsonResult dadosGrafico()
        {
            //retorna o resultado de nome e quant.
            return Json(_context.Moedas.Select(dado => new { dado.Nome, dado.Quantidade }));
        } 
        // GET: Moedas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moedas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MoedaId,Nome,Quantidade")] Moeda moeda)
        {
            if (ModelState.IsValid)
            {
                moeda.Quantidade = 0; // quando o usuario criar a moeda,a quantidade é automatica Zero
                _context.Add(moeda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moeda);
        }

    }  
}
