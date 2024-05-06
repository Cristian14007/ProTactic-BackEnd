using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class PlanUpdateDTO
{
    [Required]
    //[StringLength(30, ErrorMessage = "El titulo de la Plan debe tener menos de 30 caracteres")]
    public string Planes { get; set; }
    public string Price { get; set; }
    public string Descripcion { get; set; }
        public int Precio {get;set;}

 

}

