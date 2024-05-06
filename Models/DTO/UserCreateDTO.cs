using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
using System.Text;
public class UserCreateDTO
{
    [Required]
    public string Name { get; set; }
    public string Password {get; set;}
    public string Email {get; set;}
     public string Apellidos { get; set; }
    public string Frase { get; set; }
    
    //public string Plan { get; set; }

    }
