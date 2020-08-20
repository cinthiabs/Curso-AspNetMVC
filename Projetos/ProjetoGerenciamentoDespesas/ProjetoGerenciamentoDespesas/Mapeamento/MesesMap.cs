using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoGerenciamentoDespesas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Mapeamento
{
    public class MesesMap : IEntityTypeConfiguration<Meses>
    {
        public void Configure(EntityTypeBuilder<Meses> builder)
        {
            builder.HasKey(mes => mes.MesesId); // adicionando a chave primaria com Entity
            builder.Property(banco => banco.MesesId).ValueGeneratedNever(); //ValueGeneratedNever o banco de dados não vai gerar um numero de Identificação

            builder.Property(nome => nome.Nome).HasMaxLength(50).IsRequired();
        
            builder.HasMany(ForeignKey => ForeignKey.Despesas).WithOne(ForeignKey => ForeignKey.Meses).HasForeignKey(ForeignKey => ForeignKey.MesId).OnDelete(DeleteBehavior.Cascade); // adicionando ForeignKey / OnDelete faz com que todas as despesas sejam excluidas 

            builder.HasOne(relacao  => relacao.Salarios).WithOne(relacao => relacao.Meses).OnDelete(DeleteBehavior.Cascade); //relacionado a tabela

            builder.ToTable("Meses"); //nome da tabela
        }
    }
}
