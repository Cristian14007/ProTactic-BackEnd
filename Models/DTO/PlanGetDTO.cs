using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class PlanGetDTO
{
    [Required]
    public int PlanId {get;set;}
    
    public string Planes { get; set; }
    
    public string Price {get;set;}
    public string Descripcion { get; set; }
        public int Precio {get;set;}

   

    public PlanGetDTO()
    {
        
    }

    public Plan ToPlan()
{
    return new Plan
    {
        PlanId = this.PlanId,
        Planes = this.Planes,
        Price =this.Price,
        Descripcion = this.Descripcion,
        Precio = this.Precio

    };
}
}