using BackEnd.Models;
namespace BackEnd.Business;

public interface IUserRepository
{
    List<UserGetDTO> GetAll();
    // GetAll(int id);
    void Add(User user);
    UserGetDTO Get(int id);
    void Update(User user);
    void Delete(int id);
}