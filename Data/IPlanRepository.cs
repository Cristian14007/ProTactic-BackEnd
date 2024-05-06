using System.Data;
using BackEnd.Models;

namespace BackEnd.Data
{
    public interface IPlanRepository
    {
        List<PlanGetDTO> GetAll();
        void Add(Plan Plan);
        PlanGetDTO Get(int id);

        /* PlanGetDTO GetDTO(int id); */
        void Update(Plan Plan);
        void Delete (int id);

        void SaveChanges();
    }
}
