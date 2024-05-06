using BackEnd.Models;
using BackEnd.Data;

namespace BackEnd.Business{


    public class PlanService : IPlanService
    {

        private readonly IPlanRepository _PlanRepository;

        public PlanService(IPlanRepository PlanRepository){
            _PlanRepository = PlanRepository;
        }
        public void Add(PlanCreateDTO PlanCreateDTO)
        {
            var Plan = new Plan();
            var newPlan = Plan.modifyPlanToDTO(PlanCreateDTO);
            _PlanRepository.Add(newPlan);
        }

        public void Delete(int id)
        {
            _PlanRepository.Delete(id);
        }

        public PlanGetDTO Get(int id)
        {
            var Plan = _PlanRepository.Get(id);

            return Plan;
        }

        /* public PlanGetDTO GetDTO(int id){
            
            var Plan = _PlanRepository.GetDTO(id);

            return Plan;
        } */

        public List<PlanGetDTO> GetAll()
        {
            var Plans = _PlanRepository.GetAll();

            return Plans;
        }

        public void Update(int id, PlanUpdateDTO PlanUpdate)
        {
            //_PlanRepository.Update(Plan);
            var PlanDTO = _PlanRepository.Get(id);
            if(PlanDTO == null)
            {
                throw new KeyNotFoundException($"Plan con Id {id} no encontrada.");
            }

            var Plan = PlanDTO.ToPlan();
            Plan.Planes = PlanUpdate.Planes;
            Plan.Price = PlanUpdate.Price;
            Plan.Descripcion = PlanUpdate.Descripcion;
            Plan.Precio = PlanUpdate.Precio;
            

            _PlanRepository.Update(Plan);
            //_PlanRepository.SaveChanges();
        }
    }

}