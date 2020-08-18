using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoMoeda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoeda.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedaContexto _moedaContexto;
        public MoedasViewComponent(MoedaContexto moedaContexto)
        {
            _moedaContexto = moedaContexto;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // retornar uma lista
            return View(await _moedaContexto.Moedas.ToListAsync());
        }
    }
}
