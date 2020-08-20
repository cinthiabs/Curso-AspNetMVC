using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGerenciamentoDespesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Mapeamento
{
    public class SalariosMap: IEntityTypeConfiguration<Salarios>
    {
        public void Configure(EntityTypeBuilder<Salarios> builder)
        {
            builder.HasKey(chave => chave.SalarioID);
            builder.Property(valor => valor.Valor).IsRequired();

            builder.HasOne(foreign => foreign.Meses).WithOne(foreign => foreign.Salarios).HasForeignKey<Salarios>(foreign => foreign.MesId);
            // quando houver mas de um relacionamento, é usando HasOne e WithOne com os nomes das tabelas
            builder.ToTable("Salarios");
        }
    }
}
