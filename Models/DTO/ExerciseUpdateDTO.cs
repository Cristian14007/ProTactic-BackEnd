using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class ExerciseUpdateDTO
{
    [Required]
    //[StringLength(30, ErrorMessage = "El titulo de la obra debe tener menos de 30 caracteres")]  public string Deporte { get; set; }
        public string Deporte { get; set; }
        public string Dificultad { get; set; }
        
        public string Intensidad { get; set; }
        
        public string Personas { get; set; }
        
        public string Objetivo {get; set;}
        
        public string Nombre {get; set;}
        
        public string Descripcion {get; set;}
           
        public int Edad {get;set;}
        public string Material {get; set;}
        public string Imagen {get; set;}

}

