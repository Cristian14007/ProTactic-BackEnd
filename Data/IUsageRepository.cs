using System.Data;
using BackEnd.Models;

namespace BackEnd.Data
{
    public interface IUsageRepository
    {
        List<UsageGetDTO> GetAll();
        void Add(Usage Usage);
        UsageGetDTO Get(int id);

        /* UsageGetDTO GetDTO(int id); */
        void Update(Usage Usage);
        void Delete (int id);

        void SaveChanges();
    }
}
