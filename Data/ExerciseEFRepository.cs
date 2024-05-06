using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{

    public class ExerciseEFRepository : IExerciseRepository{

        private readonly ExerciseContext _context;

       
public ExerciseEFRepository(ExerciseContext context)
        {
            _context = context;
        }
      
        public void Add(Exercise exercise)
        {
            _context.Exercises.Add(exercise); 
            SaveChanges();

            
        }

        public void Delete(int id)
        {
            
            var exerciseDto = Get(id);
            if (exerciseDto == null)
            {
                throw new KeyNotFoundException("Exercise not found.");
            }

            var exercise = _context.Exercises.FirstOrDefault(o => o.ExerciseId == id);
            if (exercise != null)
            {
                _context.Exercises.Remove(exercise);
                SaveChanges();
            }

        }

        public ExerciseGetDTO Get(int id)
        {
            
            var exercises = _context.Exercises
                
                .ToList();

            var exercisesDTO = exercises.Select(o => new ExerciseGetDTO
            {
                ExerciseId = o.ExerciseId,
                Deporte = o.Deporte,
                Descripcion = o.Descripcion,
                Dificultad = o.Dificultad,
                Edad = o.Edad,
                Intensidad = o.Intensidad,
                Material = o.Material,
                Nombre = o.Nombre,
                Objetivo = o.Objetivo,
                Imagen = o.Imagen,
                Personas = o.Personas
                
                
            }).FirstOrDefault(o => o.ExerciseId == id);

            return exercisesDTO;
        }

        

        public List<ExerciseGetDTO> GetAll()
        {

            //return _context.Exercises.ToList();
            var exercises = _context.Exercises
                
                .ToList();
 if (exercises != null)
            {
            var exercisesDTO = exercises.Select(o => new ExerciseGetDTO
            {
               ExerciseId = o.ExerciseId,
                Deporte = o.Deporte,
                Descripcion = o.Descripcion,
                Dificultad = o.Dificultad,
                Edad = o.Edad,
                Intensidad = o.Intensidad,
                Material = o.Material,
                Nombre = o.Nombre,
                Objetivo = o.Objetivo,
                Imagen = o.Imagen,
                Personas = o.Personas
               
            }).ToList();

            return exercisesDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Update(Exercise exercise)
        {
            // Verificar si ya hay una instancia de Exercise con el mismo ExerciseId en el contexto
            var existingExercise = _context.Exercises.Find(exercise.ExerciseId);

            if (existingExercise != null)
            {
                // Si existe una instancia previa, desvincularla del contexto
                _context.Entry(existingExercise).State = EntityState.Detached;
            }

            // Adjuntar la nueva instancia de Exercise al contexto
            _context.Attach(exercise);

            // Marcar la entidad como modificada para que Entity Framework la actualice en la base de datos
            _context.Entry(exercise).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        

        
    }

}
