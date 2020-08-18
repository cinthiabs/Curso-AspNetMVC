using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTarefas.Models
{
    public class Tarefas
    {
        public int TarefasId { get; set; }
        public string Nome { get; set; }
        public string Descrica{ get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Importancia { get; set; }
    }
}
