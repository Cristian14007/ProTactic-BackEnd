using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class ExerciseGetDTO
{
    [Required]
    public int ExerciseId {get;set;}
    
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


  

    public ExerciseGetDTO()
    {
        
    }

    public Exercise ToExercise()
{
    return new Exercise
    {
        ExerciseId = this.ExerciseId,
        Deporte = this.Deporte,
        Descripcion = this.Descripcion,
        Dificultad = this.Dificultad,
        Intensidad = this.Intensidad,
        Personas = this.Personas,
        Objetivo = this.Objetivo,
        Nombre = this.Nombre,
        Edad = this.Edad,
        Material = this.Material,
        Imagen =this.Imagen
 
    
    };
}
}