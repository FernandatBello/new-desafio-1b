using System.ComponentModel.DataAnnotations;

namespace Desafio_1b.Models
{
    public class Campos
    {
        [Key]
        [Required(ErrorMessage = "O campo Nome é obrigatorio com o minimo de 3 caracteres")]
        public string? Nome { get; set; }

        [Required]
        public Disponibilidade Disponibilidade { get; set; }
        
        [Required(ErrorMessage = "O campo Anos de experiencia é obrigatorio")]
        public int AnosDeExperiencia { get; set; }
        
    }
}
