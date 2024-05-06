using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
public class Exercise
{

    [Key]
        public int ExerciseId { get; set; }
        [Required]
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
        


       

    

    public Exercise (){

    }
     public Exercise(string deporte, string descripcion,string dificultad,string intensidad, string imagen, string personas, string objetivo, int edad, string nombre, string material)
    {
        Deporte = deporte;
        Imagen = imagen;
        Descripcion = descripcion;
        Dificultad = dificultad;
        Intensidad = intensidad;
        Personas = personas;
        Objetivo = objetivo;
        Nombre = nombre;
        Edad = edad;
        Material = material;     
       
       
       
    }

    public Exercise modifyExerciseToDTO(ExerciseCreateDTO exerciseCreateDTO)
    {
        if (exerciseCreateDTO == null)
        {
            
            throw new ArgumentNullException(nameof(exerciseCreateDTO));
        }

        var exercise = new Exercise
        {
            Deporte = exerciseCreateDTO.Deporte,
            Descripcion = exerciseCreateDTO.Descripcion,
            Imagen = exerciseCreateDTO.Imagen,
            Dificultad = exerciseCreateDTO.Dificultad,
            Intensidad = exerciseCreateDTO.Intensidad,
            Personas = exerciseCreateDTO.Personas,
            Objetivo = exerciseCreateDTO.Objetivo,
            Nombre = exerciseCreateDTO.Nombre,
            Edad = exerciseCreateDTO.Edad,
            Material = exerciseCreateDTO.Material

            
        };

        return exercise;
    }

    

}
