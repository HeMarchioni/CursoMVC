using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {

        public int Id { get; set; }

        [Display(Name ="Descrição")] // -> usando a anotação para definir como ira ser mostrado na tela
        public string Descricao { get; set; }

        [Range(1,10, ErrorMessage ="Valor fora da Faixa")] // -> anotãção de validação Range -> ja informa direto no display
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }


    }
}
