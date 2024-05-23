using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;
public class AmigoUpdateDTO
{
    [Required]
    public string Usuario { get; set; }
    public string Amigos {get; set;}

    }
