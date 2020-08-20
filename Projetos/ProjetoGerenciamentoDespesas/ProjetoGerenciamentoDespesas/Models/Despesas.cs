using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Models
{
    public class Despesas
    {
        public int DespesasId {get;set;}

        public int MesId { get; set; }
        public Meses Meses { get; set; } // adicionando as a classe e tabela Meses ForeignKey

        public int TipoDespesaId { get; set; }
        public TipoDespesas TipoDespesas { get; set; } // adicionando as a classe e tabela TipoDespesas ForeignKey

        [Required(ErrorMessage = "Campo Obrigatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor Inválido")] // definindo calor minimo e maximo
        public double Valor { get; set; }

    }
}
