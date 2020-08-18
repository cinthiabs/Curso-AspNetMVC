using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMoeda.Models
{
    public class Moeda
    {
        public int MoedaId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        [NotMapped] //não será mapeado para o banco de dados
        public bool CheckboxMarcado { get; set; }
    }
}
