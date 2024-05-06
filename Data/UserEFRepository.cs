using BackEnd.Models;
using System.Text.Json;
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using BackEnd.Data;
using BackEnd.Business;

namespace BackEnd.Data
{

    public class UserEFRepository : IUserRepository
    {


        private readonly ExerciseContext _context;

        public UserEFRepository(ExerciseContext context)
        {
            _context = context;
        }

        public List<UserGetDTO> GetAll()
        {
            var users = _context.Users
                .ToList();

            if (users != null)
            {
                var UserGetDTO = users.Select(u => new UserGetDTO
                {
                    UserId = u.UserId,
                    Name = u.Name,
                    Password = u.Password,
                    Email = u.Email,
                    Apellidos = u.Apellidos,
                    Frase = u.Frase,
                    Plan = u.Plan
                }).ToList();
                return UserGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }

        public UserGetDTO Get(int id)
        {
            var user = _context.Users
                .Where(user => user.UserId == id)
                .FirstOrDefault();

            if (user != null)
            {
                var UserGetDTO = new UserGetDTO
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Password = user.Password,
                    Email = user.Email,
                     Apellidos = user.Apellidos,
                    Frase = user.Frase,
                    Plan = user.Plan
                };

                return UserGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        public void Update(User user)
        {
            // Cargar la instancia existente de Exercise desde el contexto
            var existingUser = _context.Users.Find(user.UserId);

            if (existingUser != null)
            {
                // Copiar las propiedades actualizadas de la nueva instancia a la instancia existente
                _context.Entry(existingUser).CurrentValues.SetValues(user);

                // Guardar los cambios en el contexto
                _context.SaveChanges();
            }
        }


        public void Delete(int id)
        {
            var UserGetDTO = Get(id);
            if (UserGetDTO == null)
            {
                throw new KeyNotFoundException("Exercise not found.");
            }

            var user = _context.Users.FirstOrDefault(u => u.UserId == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                SaveChanges();
            }
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}