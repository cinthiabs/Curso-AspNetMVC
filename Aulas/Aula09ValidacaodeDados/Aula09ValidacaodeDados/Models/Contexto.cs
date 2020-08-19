using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09ValidacaodeDados.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Cadastro> Cadastros { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }
    }
}
