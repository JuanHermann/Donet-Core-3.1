using System;
using System.ComponentModel.DataAnnotations;
using RestDotnet.Abastracts;

namespace RestDotnet.Models
{
    public class Motorcycle : Vehicle
    {
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public Boolean HaveSpecialSuspension { get; set; }

        public override int WheelNumber()
        {
            return 2;
        }

    }

}