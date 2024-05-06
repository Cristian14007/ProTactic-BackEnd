using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
using System.Text;
public class UserGetDTO
{
    [Required]
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Apellidos { get; set; }
    public string Frase { get; set; }
    public string Plan { get; set; }

    public User ToUser()
    {
        return new User
        {
            UserId = this.UserId,
            Name = this.Name,
            Password = this.Password,
            Email = this.Email,
            Apellidos = this.Apellidos,
            Frase = this.Frase,
            Plan = this.Plan
        };
    }
}