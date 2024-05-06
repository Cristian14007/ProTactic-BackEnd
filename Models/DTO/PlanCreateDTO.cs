using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class PlanCreateDTO
    {
        
        public string Planes { get; set; }
        
        public string Price { get; set; }
        public string Descripcion { get; set; }
        public int Precio {get;set;}
        
      
    }
}