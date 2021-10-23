using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{

    public class Categoria
    {

        public int Id { get; set;}
        
        [Display(Name = "Descrição")] // -> usando a anotação para definir como ira ser mostrado na tela
        [Required(ErrorMessage ="O Campo descrição é obrigatorio")]   // -> anotation para falar que o campo é obrigatorio mandar mensagem
        public string Descricao { get; set;}

        




    }
}
