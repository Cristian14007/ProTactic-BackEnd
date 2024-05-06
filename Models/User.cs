using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class User
{
    [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Apellidos { get; set; }
    public string Frase { get; set; }
    public string Plan { get; set; }

    public User() { }
    public User(int userId, string name, string email, string password, string apellidos, string frase, string plan)
    {
        UserId = userId;
        Name = name;
        Email = email;
        Password = password;
        Apellidos = apellidos;
        Frase = frase;
        Plan = plan;
        
    }
    public User mapFromCreateDto(UserCreateDTO userCreateDTO)
    {
        if (userCreateDTO == null)
        {
            throw new ArgumentNullException(nameof(userCreateDTO));
        }

        var user = new User
        {
            Name = userCreateDTO.Name,
            Password = userCreateDTO.Password,
            Email = userCreateDTO.Email,
            Apellidos = userCreateDTO.Apellidos,
            Frase = userCreateDTO.Frase,
            Plan = "Basico"
            
            
        };

        return user;
    }
}