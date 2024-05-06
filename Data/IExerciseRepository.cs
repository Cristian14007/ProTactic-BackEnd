using System.Data;
using BackEnd.Models;

namespace BackEnd.Data
{
    public interface IExerciseRepository
    {
        List<ExerciseGetDTO> GetAll();
        void Add(Exercise exercise);
        ExerciseGetDTO Get(int id);

        /* ExerciseGetDTO GetDTO(int id); */
        void Update(Exercise exercise);
        void Delete (int id);

        void SaveChanges();
    }
}