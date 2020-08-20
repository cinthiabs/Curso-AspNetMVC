using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProjetoGerenciamentoDespesas.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Models
{
    public class Contexto: DbContext
    {
        // adicioando as classes  criadas 
        public DbSet<Meses> Meses { get; set; }
        public DbSet<Salarios> Salarios { get; set; }
        public DbSet<DespesasMap> Despesas { get; set; }
        public DbSet<TipoDespesas> TipoDespesas { get; set; }

     public Contexto(IDesignTimeDbContextFactory<Contexto> design){ }
        public Contexto(DbContextOptions <Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoDespesasMap());

            modelBuilder.ApplyConfiguration(new SalariosMap());
            modelBuilder.ApplyConfiguration(new MesesMap());
            modelBuilder.ApplyConfiguration(new DespesasMap());


        }
    }
}
