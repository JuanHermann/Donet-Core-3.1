using System;
using System.ComponentModel.DataAnnotations;
using RestDotnet.Abastracts;

namespace RestDotnet.Models
{
    public class Car : Vehicle
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Boolean HaveFrontGuard { get; set; }

        public override int WheelNumber()
        {
            return 4;
        }

    }

}