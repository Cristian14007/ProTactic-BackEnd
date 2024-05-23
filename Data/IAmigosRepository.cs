using BackEnd.Models;
namespace BackEnd.Business;

public interface IAmigoRepository
{
    List<AmigoGetDTO> GetAll();
    // GetAll(int id);
    void Add(Amigo Amigo);
    AmigoGetDTO Get(int id);
    void Update(Amigo Amigo);
    void Delete(int id);
}