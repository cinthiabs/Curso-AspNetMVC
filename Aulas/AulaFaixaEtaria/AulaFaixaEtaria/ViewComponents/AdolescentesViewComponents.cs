using AulaFaixaEtaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaFaixaEtaria.ViewComponents
{
    public class AdolescentesViewComponents : ViewComponent
    {
        private readonly PessoaContexto _pessoaContexto;
        public AdolescentesViewComponents(PessoaContexto pessoaContexto)
        {
            _pessoaContexto = pessoaContexto;
        }
        public async Task<IViewComponentResult> InokeAsync()
        {
            return View(await _pessoaContexto.Pessoas.Where(x => x.Idade < 18).ToListAsync());
        }
    }
}
