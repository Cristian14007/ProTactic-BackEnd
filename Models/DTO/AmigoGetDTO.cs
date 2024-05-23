using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;
using System.Text;
public class AmigoGetDTO
{
    [Required]
    public int AmigoId { get; set; }
    public string Usuario { get; set; }
    public string Amigos { get; set; }

    public Amigo ToAmigo()
    {
        return new Amigo
        {
            AmigoId = this.AmigoId,
            Usuario = this.Usuario,
            Amigos = this.Amigos,
           
        };
    }
}