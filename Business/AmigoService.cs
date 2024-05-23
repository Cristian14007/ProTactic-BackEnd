using BackEnd.Data;
using BackEnd.Business;
using BackEnd.Models;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;


namespace BackEnd.Business
{
    public class AmigoService : IAmigoService
    {

        private readonly IAmigoRepository _amigoRepository;

        public AmigoService(IAmigoRepository amigoRepository)
        {
            _amigoRepository = amigoRepository;

        }
        public List<AmigoGetDTO> GetAll()
        {
            var amigos = _amigoRepository.GetAll();
            return amigos;
        }


        public AmigoGetDTO Get(int id)
        {
            var amigo = _amigoRepository.Get(id);
            return amigo;
        }


        public void Add(AmigoCreateDTO amigoCreateDTO)
        {
            var amigo = new Amigo();
            var mappedAmigo = amigo.mapFromCreateDto(amigoCreateDTO);
            _amigoRepository.Add(mappedAmigo);
        }

        public void Update(int id, AmigoUpdateDTO amigoUpdateDTO)
        {
            var AmigoGetDTO = _amigoRepository.Get(id);
            if (AmigoGetDTO == null)
            {
                throw new KeyNotFoundException($"Exercise con Id {id} no encontrada.");
            }

            // Mapea los datos del DTO a la entidad Exercise
            var amigo = AmigoGetDTO.ToAmigo();
            amigo.Usuario = amigoUpdateDTO.Usuario;
            amigo.Amigos = amigoUpdateDTO.Amigos;
            

            // Llama al método Update del repositorio con la entidad Exercise actualizada
            _amigoRepository.Update(amigo);
        }



        public void Delete(int id)
        {
            _amigoRepository.Delete(id);
        }
    }




}