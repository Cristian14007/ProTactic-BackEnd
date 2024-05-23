using BackEnd.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;
using BackEnd.Business;

namespace BackEnd.Data
{

    public class AmigoEFRepository : IAmigoRepository
    {


        private readonly ExerciseContext _context;

        public AmigoEFRepository(ExerciseContext context)
        {
            _context = context;
        }

        public List<AmigoGetDTO> GetAll()
        {
            var Amigos = _context.Amigos
                .ToList();

            if (Amigos != null)
            {
                var AmigoGetDTO = Amigos.Select(f => new AmigoGetDTO
                {
                    AmigoId = f.AmigoId,
                    Usuario = f.Usuario,
                    Amigos = f.Amigos
                    
                }).ToList();
                return AmigoGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Add(Amigo Amigo)
        {
            _context.Amigos.Add(Amigo);
            SaveChanges();
        }

        public AmigoGetDTO Get(int id)
        {
            var Amigo = _context.Amigos
                .Where(Amigo => Amigo.AmigoId == id)
                .FirstOrDefault();

            if (Amigo != null)
            {
                var AmigoGetDTO = new AmigoGetDTO
                {
                    AmigoId = Amigo.AmigoId,
                    Usuario = Amigo.Usuario,
                    Amigos = Amigo.Amigos
                    
                };

                return AmigoGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        public void Update(Amigo Amigo)
        {
            // Cargar la instancia existente de Exercise desde el contexto
            var existingAmigo = _context.Amigos.Find(Amigo.AmigoId);

            if (existingAmigo != null)
            {
                // Copiar las propiedades actualizadas de la nueva instancia a la instancia existente
                _context.Entry(existingAmigo).CurrentValues.SetValues(Amigo);

                // Guardar los cambios en el contexto
                _context.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var AmigoGetDTO = Get(id);
            if (AmigoGetDTO == null)
            {
                throw new KeyNotFoundException("Exercise not found.");
            }

            var Amigo = _context.Amigos.FirstOrDefault(f => f.AmigoId == id);
            if (Amigo != null)
            {
                _context.Amigos.Remove(Amigo);
                SaveChanges();
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}