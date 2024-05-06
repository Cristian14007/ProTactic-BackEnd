using BackEnd.Models;

namespace BackEnd.Business
{
    public interface IExerciseService
    {
        List<ExerciseGetDTO> GetAll();
        void Add(ExerciseCreateDTO exerciseCreateDTO);
        ExerciseGetDTO Get(int id);

        /* ExerciseGetDTO GetDTO(int id); */
        public void Update(int id, ExerciseUpdateDTO exerciseUpdate);
        void Delete (int id);


    }
}