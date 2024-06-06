
using BackEnd.Models;

namespace BackEnd.Business
{
    public interface IUsageService
    {
        List<UsageGetDTO> GetAll();
        void Add(UsageCreateDTO UsageCreateDTO);
        UsageGetDTO Get(int id);

        /* UsageGetDTO GetDTO(int id); */
        public void Update(int id, UsageUpdateDTO UsageUpdate);
        void Delete (int id);


    }
}