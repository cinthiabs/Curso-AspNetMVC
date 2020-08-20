using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGerenciamentoDespesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Mapeamento
{
    public class DespesasMap : IEntityTypeConfiguration<Despesas>
    {
        
        
            public void Configure(EntityTypeBuilder<Despesas> builder)
            {
                builder.HasKey(chave => chave.DespesasId);
                builder.Property(valor => valor.Valor).IsRequired();

                builder.HasOne(foreign => foreign.Meses).WithMany(foreign => foreign.Despesas).HasForeignKey(foreign => foreign.MesId);
                builder.HasOne(foreign => foreign.TipoDespesas).WithMany(foreign => foreign.Despesas).HasForeignKey(foreign => foreign.TipoDespesaId);
                builder.ToTable("Despesas");
            }
        
    }
}
