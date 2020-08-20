using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Models
{
    public class TipoDespesas
    {
        public int TipoDespesasId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio.")]
        [StringLength(50, ErrorMessage ="Maximo de caracteres 20.")]
        public string Nome { get; set; }
        public ICollection<Despesas> Despesas { get; set; } // está relacionado a outra tabela ForeignKey
    }
}
