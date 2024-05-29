using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
public class Usage
{

    [Key]
        public int UsageId { get; set; }
        [Required]
        public string Month { get; set; }
        public int Futbol { get; set; }
        public int Basket {get;set;}
        public int Basico {get;set;}
        public int Medium {get;set;}
        public int Pro {get;set;}
        public int Clientes {get;set;}
        
       

    

    public Usage (){

    }
     public Usage( string month, int futbol, int basket, int basico, int medium, int pro, int clientes)
    {
        Month = month;
        Futbol = futbol;
        Basket = basket;
        Basico = basico;
        Medium = medium;
        Pro = pro;
        Clientes = clientes;    
        
        
       
    }

    public Usage modifyUsageToDTO(UsageCreateDTO UsageCreateDTO)
    {
        if (UsageCreateDTO == null)
        {
            
            throw new ArgumentNullException(nameof(UsageCreateDTO));
        }

        var Usage = new Usage
        {
            Month = UsageCreateDTO.Month,
            Futbol = UsageCreateDTO.Futbol,
            Basket = UsageCreateDTO.Basket,
            Basico = UsageCreateDTO.Basico,
            Medium = UsageCreateDTO.Medium,
            Pro = UsageCreateDTO.Pro,
            Clientes = UsageCreateDTO.Clientes
              
        };

        return Usage;
    }

    

}