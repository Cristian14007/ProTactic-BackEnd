using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class UsageCreateDTO
    {
        
       public string Month { get; set; }
        public int Futbol { get; set; }
        public int Basket {get;set;}
        public int Basico {get;set;}
        public int Medium {get;set;}
        public int Pro {get;set;}
        public int Clientes {get;set;}
        
      
    }
}