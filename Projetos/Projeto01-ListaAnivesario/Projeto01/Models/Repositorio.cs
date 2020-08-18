using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto01.Models
{
    public class Repositorio

    {
        private static List<RespostaConvidados> LISTA = new List<RespostaConvidados>();

        public static void AdicionarResposta(RespostaConvidados resposta)
        {
            LISTA.Add(resposta);
        }
          public static IEnumerable <RespostaConvidados> ListaFinal
        {
            get{ return LISTA; }
        }

    }
}
