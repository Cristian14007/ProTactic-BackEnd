using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
public class Plan
{

    [Key]
        public int PlanId { get; set; }
        [Required]
        public string Planes { get; set; }
        
        public string Price { get; set; }
        public string Descripcion { get; set; }
        public int Precio {get;set;}
        
       

    

    public Plan (){

    }
     public Plan(string planes, string price, int precio, string descripcion)
    {
        Planes = planes;
        Price = price;
        Descripcion = descripcion;
        Precio = precio;
        
       
    }

    public Plan modifyPlanToDTO(PlanCreateDTO PlanCreateDTO)
    {
        if (PlanCreateDTO == null)
        {
            
            throw new ArgumentNullException(nameof(PlanCreateDTO));
        }

        var Plan = new Plan
        {
            Planes = PlanCreateDTO.Planes,
            Price = PlanCreateDTO.Price,
            Descripcion = PlanCreateDTO.Descripcion,
            Precio = PlanCreateDTO.Precio
              
        };

        return Plan;
    }

    

}