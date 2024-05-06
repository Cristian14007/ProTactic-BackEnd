using BackEnd.Models;
using BackEnd.Data;

namespace BackEnd.Business{


    public class ExerciseService : IExerciseService
    {

        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository){
            _exerciseRepository = exerciseRepository;
        }
        public void Add(ExerciseCreateDTO exerciseCreateDTO)
        {
            var exercise = new Exercise();
            var newExercise = exercise.modifyExerciseToDTO(exerciseCreateDTO);
            _exerciseRepository.Add(newExercise);
        }

        public void Delete(int id)
        {
            _exerciseRepository.Delete(id);
        }

        public ExerciseGetDTO Get(int id)
        {
            var exercise = _exerciseRepository.Get(id);

            return exercise;
        }

        /* public ExerciseGetDTO GetDTO(int id){
            
            var exercise = _exerciseRepository.GetDTO(id);

            return exercise;
        } */

        public List<ExerciseGetDTO> GetAll()
        {
            var exercises = _exerciseRepository.GetAll();

            return exercises;
        }

        public void Update(int id, ExerciseUpdateDTO exerciseUpdate)
        {
            //_exerciseRepository.Update(exercise);
            var exerciseDTO = _exerciseRepository.Get(id);
            if(exerciseDTO == null)
            {
                throw new KeyNotFoundException($"Exercise con Id {id} no encontrada.");
            }

            var exercise = exerciseDTO.ToExercise();
            exercise.Deporte = exerciseUpdate.Deporte;
            exercise.Descripcion = exerciseUpdate.Descripcion;
            exercise.Dificultad = exerciseUpdate.Dificultad;
            exercise.Intensidad = exerciseUpdate.Intensidad;
            exercise.Personas = exerciseUpdate.Personas;
            exercise.Objetivo = exerciseUpdate.Objetivo;
            exercise.Nombre = exerciseUpdate.Nombre;
            exercise.Edad = exerciseUpdate.Edad;
            exercise.Material = exerciseUpdate.Material;
            exercise.Imagen = exerciseUpdate.Imagen;

            _exerciseRepository.Update(exercise);
            //_exerciseRepository.SaveChanges();
        }
    }

}
