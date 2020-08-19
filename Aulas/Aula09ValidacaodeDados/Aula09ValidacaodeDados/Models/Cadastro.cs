using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09ValidacaodeDados.Models
{
    public class Cadastro
    {
        public int CadastroID { get; set; }


        [Remote("PesquisarUsuario","Cadastro")] // validação remota, passa o nome do Metodo, e o nome da Classe

        [Required(ErrorMessage = "Campo Obrigatorio")] // Required faz com que o campo fique obrigatorio
        [StringLength(20 , ErrorMessage ="Maximo de Caracteres permitido 20")] // Limita o campo até 20 caracteres
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")] // Required faz com que o campo fique obrigatorio
        [Range(1,90, ErrorMessage ="Idade Invalida")] // Limita o campo até 20 caracteresSó aceita valores entre 1 e 100
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DataType(DataType.Date)] // tipo de dado em data
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DataType(DataType.EmailAddress)] // tipo de dado em e-mail
        [StringLength(50, ErrorMessage = "Maximo de Caracteres permitido 50")] // limitando a 50 caracteres 
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [DataType(DataType.EmailAddress)] // tipo de dado em e-mail
        [StringLength(50, ErrorMessage = "Maximo de Caracteres permitido 50")] // limitando a 50 caracteres 
        [Compare("Email")] // comparar com o email digitado a sima 
        public string ConfirmarEmail { get; set; }
    }
}
