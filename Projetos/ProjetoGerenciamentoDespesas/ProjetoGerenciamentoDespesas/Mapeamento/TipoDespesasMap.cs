using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGerenciamentoDespesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Mapeamento
{
    public class TipoDespesasMap: IEntityTypeConfiguration<TipoDespesas>
    {
        public void  Configure(EntityTypeBuilder<TipoDespesas> builder)
        {
            builder.HasKey(Primaria => Primaria.TipoDespesasId); // adicionando a chave primaria com Entity
            builder.Property(nome => nome.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(foreignKey => foreignKey.Despesas).WithOne(foreignKey => foreignKey.TipoDespesas).HasForeignKey(foreignKey => foreignKey.TipoDespesaId); // adicionando ForeignKey

            builder.ToTable("TipoDespesas");
        }
    }
}
