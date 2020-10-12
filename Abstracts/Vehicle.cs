using System;
using System.ComponentModel.DataAnnotations;
using RestDotnet.Models;

namespace RestDotnet.Abastracts
{
    public abstract class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Color { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public virtual int WheelNumber()
        {
            return 0;
        }

    }
}