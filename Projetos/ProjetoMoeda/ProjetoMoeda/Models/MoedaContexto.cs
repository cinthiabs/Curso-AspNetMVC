using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoeda.Models
{
    public class MoedaContexto:DbContext
    {
        public DbSet<Moeda> Moedas { get; set; } // contrunido o banco 'Moedas' é o nome do banco
        //contrutor
        public MoedaContexto(DbContextOptions<MoedaContexto> opcoes):base(opcoes)
        {

        }
    }
}
