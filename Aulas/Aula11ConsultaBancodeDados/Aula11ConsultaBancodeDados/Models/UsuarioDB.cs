using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula11ConsultaBancodeDados.Models
{
    public class UsuarioDB
    {
        [Key]
        public int UsuarioID { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
    }
}
