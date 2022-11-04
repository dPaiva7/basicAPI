using System.ComponentModel.DataAnnotations;

namespace BasicAPI.Models
{
    public class Fornecedor
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Campo deve ter no mínimo 4 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Contato { get; set; }
    }
}

      
    
    


