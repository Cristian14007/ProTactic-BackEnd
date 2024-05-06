
using BackEnd.Models;

namespace BackEnd.Business
{
    public interface IPlanService
    {
        List<PlanGetDTO> GetAll();
        void Add(PlanCreateDTO PlanCreateDTO);
        PlanGetDTO Get(int id);

        /* PlanGetDTO GetDTO(int id); */
        public void Update(int id, PlanUpdateDTO PlanUpdate);
        void Delete (int id);


    }
}