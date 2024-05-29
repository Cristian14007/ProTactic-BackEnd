using BackEnd.Models;
using BackEnd.Data;

namespace BackEnd.Business{


    public class UsageService : IUsageService
    {

        private readonly IUsageRepository _UsageRepository;

        public UsageService(IUsageRepository UsageRepository){
            _UsageRepository = UsageRepository;
        }
        public void Add(UsageCreateDTO UsageCreateDTO)
        {
            var Usage = new Usage();
            var newUsage = Usage.modifyUsageToDTO(UsageCreateDTO);
            _UsageRepository.Add(newUsage);
        }

        public void Delete(int id)
        {
            _UsageRepository.Delete(id);
        }

        public UsageGetDTO Get(int id)
        {
            var Usage = _UsageRepository.Get(id);

            return Usage;
        }

        /* public UsageGetDTO GetDTO(int id){
            
            var Usage = _UsageRepository.GetDTO(id);

            return Usage;
        } */

        public List<UsageGetDTO> GetAll()
        {
            var Usages = _UsageRepository.GetAll();

            return Usages;
        }

        public void Update(int id, UsageUpdateDTO UsageUpdate)
        {
            //_UsageRepository.Update(Usage);
            var UsageDTO = _UsageRepository.Get(id);
            if(UsageDTO == null)
            {
                throw new KeyNotFoundException($"Usage con Id {id} no encontrada.");
            }

            var Usage = UsageDTO.ToUsage();
            Usage.Month = UsageUpdate.Month;
            Usage.Futbol = UsageUpdate.Futbol;
            Usage.Basket = UsageUpdate.Basket;
            Usage.Basico = UsageUpdate.Basico;
            Usage.Medium = UsageUpdate.Medium;
            Usage.Pro = UsageUpdate.Pro;
            Usage.Clientes = UsageUpdate.Clientes;

            

            _UsageRepository.Update(Usage);
            //_UsageRepository.SaveChanges();
        }
    }

}