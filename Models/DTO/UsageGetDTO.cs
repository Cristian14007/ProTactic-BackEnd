using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class UsageGetDTO
{
    [Required]
    public int UsageId {get;set;}
    
    
      public string Month { get; set; }
        public int Futbol { get; set; }
        public int Basket {get;set;}
        public int Basico {get;set;}
        public int Medium {get;set;}
        public int Pro {get;set;}
        public int Clientes {get;set;}
   

    public UsageGetDTO()
    {
        
    }

    public Usage ToUsage()
{
    return new Usage
    {
        UsageId = this.UsageId,
        Month = this.Month,
        Futbol =this.Futbol,
        Basket = this.Basket,
        Basico = this.Basico,
        Medium = this.Medium,
        Pro = this.Pro,
        Clientes = this.Clientes

    };
}
}