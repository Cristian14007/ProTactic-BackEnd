using System.Data.Common;
using BackEnd.Models;
namespace BackEnd.Business;

public interface IAmigoService
{
    List<AmigoGetDTO> GetAll();
    void Add(AmigoCreateDTO amigoCreateDTO);
    AmigoGetDTO Get(int id);
    void Update(int id, AmigoUpdateDTO amigoUpdateDTO);
    void Delete(int id);
}