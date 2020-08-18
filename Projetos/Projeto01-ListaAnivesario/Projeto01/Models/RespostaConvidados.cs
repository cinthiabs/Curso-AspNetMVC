using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto01.Models
{
    public class RespostaConvidados
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool? Presente { get; set; } //bool? aceita 3 valores, true,false e null
    }
}
