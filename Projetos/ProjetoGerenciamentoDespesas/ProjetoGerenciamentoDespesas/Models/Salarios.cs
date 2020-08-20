using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoGerenciamentoDespesas.Models
{
    public class Salarios
    {
        public int SalarioID { get; set; }

        public int MesId { get; set; }
        public Meses Meses { get; set; }
    
        [Required(ErrorMessage ="Campo Obrigatorio.")]
        [Range(0 , double.MaxValue, ErrorMessage ="Valor Inválido")] // definindo calor minimo e maximo
        public double Valor { get; set; }

    }
}
