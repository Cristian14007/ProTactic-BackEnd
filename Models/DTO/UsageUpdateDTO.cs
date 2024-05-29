using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class UsageUpdateDTO
{
    [Required]
    //[StringLength(30, ErrorMessage = "El titulo de la Usage debe tener menos de 30 caracteres")]

      public string Month { get; set; }
        public int Futbol { get; set; }
        public int Basket {get;set;}
        public int Basico {get;set;}
        public int Medium {get;set;}
        public int Pro {get;set;}
        public int Clientes {get;set;}

 

}

