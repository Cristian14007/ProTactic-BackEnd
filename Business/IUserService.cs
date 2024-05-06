using System.Data.Common;
using BackEnd.Models;
namespace BackEnd.Business;

public interface IUserService
{
    List<UserGetDTO> GetAll();
    void Add(UserCreateDTO userCreateDTO);
    UserGetDTO Get(int id);
    void Update(int id, UserUpdateDTO userUpdateDTO);
    void Delete(int id);
}