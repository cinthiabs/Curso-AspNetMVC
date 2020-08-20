using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Models
{
    public class Meses
    {
        public int MesesId { get; set; }
        public string Nome { get; set; }

        public ICollection<Despesas> Despesas { get; set; } // está relacionado a outra tabela  ForeignKey
        public Salarios Salarios { get; set; }
    }
}
