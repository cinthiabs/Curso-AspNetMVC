using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aula11ConsultaBancodeDados.Models;

namespace Aula11ConsultaBancodeDados.Controllers
{
    public class UsuarioDBController : Controller
    {
        private readonly Contexto _context;

        public UsuarioDBController(Contexto context)
        {
            _context = context;
        }

        // GET: UsuarioDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioDB.ToListAsync());
        }
        public async Task<IActionResult>Index(string txtProcurar)
        {
            if(!string.IsNullOrEmpty(txtProcurar)) // se txtProcurar não for vazio ou nulo
            {
                return View(await _context.UsuarioDB.Where(procura => procura.NomeCompleto.ToUpper().Contains(txtProcurar.ToUpper())).ToListAsync()); // toUpper, aceita letras caixa alta e baixa
            }
            else
            {
                
                return View(await _context.UsuarioDB.ToListAsync());
            }
        }

        // GET: UsuarioDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioDB = await _context.UsuarioDB
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuarioDB == null)
            {
                return NotFound();
            }

            return View(usuarioDB);
        }

        // GET: UsuarioDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioDBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsuarioID,NomeCompleto,Idade")] UsuarioDB usuarioDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioDB);
        }

        // GET: UsuarioDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioDB = await _context.UsuarioDB.FindAsync(id);
            if (usuarioDB == null)
            {
                return NotFound();
            }
            return View(usuarioDB);
        }

        // POST: UsuarioDBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsuarioID,NomeCompleto,Idade")] UsuarioDB usuarioDB)
        {
            if (id != usuarioDB.UsuarioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioDBExists(usuarioDB.UsuarioID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioDB);
        }

        // GET: UsuarioDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioDB = await _context.UsuarioDB
                .FirstOrDefaultAsync(m => m.UsuarioID == id);
            if (usuarioDB == null)
            {
                return NotFound();
            }

            return View(usuarioDB);
        }

        // POST: UsuarioDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioDB = await _context.UsuarioDB.FindAsync(id);
            _context.UsuarioDB.Remove(usuarioDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioDBExists(int id)
        {
            return _context.UsuarioDB.Any(e => e.UsuarioID == id);
        }
    }
}
