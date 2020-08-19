using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10ValidaçãoDados2.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key] // adicionado chave primaria
        [Column("UsuarioId",TypeName = "int")] // adicionado a coluna com o tipo de dados 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // na chave primaria, gerar um numero automaticamente com o Identity
        public int PersonId { get; set; }

        [Column ("Nome" , TypeName ="ntext")]
        [Display(Name = "Nome Completo")] // display é o que fica a mostra para o usuario 
        public string Name { get; set; }

        [Column("CPF", TypeName = "ntext")]
        [Display(Name = "Cadastro de Pessoa Fisica")]
        public string CPF { get; set; }

        [Column("Nascimento", TypeName = "date")]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Column("Idade", TypeName = "int")]
        [Display(Name = "Idade")]
        public int Age { get; set; }
      

    }
}
