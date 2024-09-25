using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoID { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [MaxLength(100, ErrorMessage = "O campo deve conter, no máximo, 100 caracteres!")]
        [MinLength(3, ErrorMessage = "O campo deve conter, no mínimo, 3 caracteres!")]
        public string ProdutoNome { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor do produto deve ser um número positivo!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "O campo não pode ser vazio!")]
        [Range(0, double.MaxValue, ErrorMessage = "A quantidade em estoque deve ser positivo!")]
        [Display(Name = "Estoque Atual")]
        public double QtadeEstoque { get; set; }

        [Display(Name = "Ativo?")]
        public bool CadastroAtivo { get; set; } = true;

        //Chave Estrangeira
        [Required(ErrorMessage = "Por favor, selecione uma categoria!")]
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
