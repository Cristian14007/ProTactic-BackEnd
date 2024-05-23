using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class Amigo
{
    [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AmigoId { get; set; }
    public string Usuario { get; set; }
    public string Amigos { get; set; }
 

    public Amigo() { }
    public Amigo(int AmigoId, string usuario, string amigos)
    {
        AmigoId = AmigoId;
        Usuario = usuario;
        Amigos = amigos;
       
        
    }
    public Amigo mapFromCreateDto(AmigoCreateDTO AmigoCreateDTO)
    {
        if (AmigoCreateDTO == null)
        {
            throw new ArgumentNullException(nameof(AmigoCreateDTO));
        }

        var Amigo = new Amigo
        {
            Usuario = AmigoCreateDTO.Usuario,
            Amigos = AmigoCreateDTO.Amigos,
            
            
            
        };

        return Amigo;
    }
}