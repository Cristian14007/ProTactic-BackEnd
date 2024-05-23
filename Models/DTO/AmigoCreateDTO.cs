using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
using System.Text;
public class AmigoCreateDTO
{
    [Required]
    public string Usuario { get; set; }
    public string Amigos {get; set;}


    }
