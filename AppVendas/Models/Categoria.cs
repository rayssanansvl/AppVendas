using System.ComponentModel.DataAnnotations;

namespace AppVendas.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo é obrigatório!")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter, no máximo, 100 caracteres!")]
        public string CategoriaNome { get; set; }
    }
}
