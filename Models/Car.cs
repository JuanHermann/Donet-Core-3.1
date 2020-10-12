using System.ComponentModel.DataAnnotations;

namespace RestDotnet.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        [MaxLength(60, ErrorMessage = "Campo deve conter no maximo 60 caracteres!")]
        [MinLength(3, ErrorMessage = "Campo deve conter no minimo 3 caracteres!")]
        public string Name { get; set; }
    }
}