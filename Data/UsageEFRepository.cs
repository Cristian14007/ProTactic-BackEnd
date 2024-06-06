using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{

    public class UsageEFRepository : IUsageRepository{

         private readonly ExerciseContext _context;

       

        public UsageEFRepository(ExerciseContext context){
            _context = context;
           
        }

        public void Add(Usage Usage)
        {
            _context.Usages.Add(Usage); 
            SaveChanges();

          
        }

        public void Delete(int id)
        {
            
            var UsageDto = Get(id);
            if (UsageDto == null)
            {
                throw new KeyNotFoundException("Usage not found.");
            }

            var Usage = _context.Usages.FirstOrDefault(o => o.UsageId == id);
            if (Usage != null)
            {
                _context.Usages.Remove(Usage);
                SaveChanges();
            }

        }

       public UsageGetDTO Get(int id)
        {
            var Usage = _context.Usages
                .Where(Usage => Usage.UsageId == id)
                .FirstOrDefault();

            if (Usage != null)
            {
                var UsageGetDTO = new UsageGetDTO
                {
                    UsageId = Usage.UsageId,
                    Month = Usage.Month,
                    Futbol = Usage.Futbol,
                    Basket = Usage.Basket,
                    Basico = Usage.Basico,
                    Medium = Usage.Medium,
                    Pro = Usage.Pro,
                    Clientes = Usage.Clientes
                    
                };

                return UsageGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        

        public List<UsageGetDTO> GetAll()
        {
            var Usages = _context.Usages
                .ToList();

            if (Usages != null)
            {
                var UsageGetDTO = Usages.Select(d => new UsageGetDTO
                {
                    UsageId = d.UsageId,
                   Month = d.Month,
                    Futbol = d.Futbol,
                    Basket = d.Basket,
                    Basico = d.Basico,
                    Medium = d.Medium,
                    Pro = d.Pro,
                    Clientes = d.Clientes
                }).ToList();
                return UsageGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Update(Usage Usage)
        {
            // Verificar si ya hay una instancia de Usage con el mismo UsageId en el contexto
            var existingUsage = _context.Usages.Find(Usage.UsageId);

            if (existingUsage != null)
            {
                // Si existe una instancia previa, desvincularla del contexto
                _context.Entry(existingUsage).State = EntityState.Detached;
            }

            // Adjuntar la nueva instancia de Usage al contexto
            _context.Attach(Usage);

            // Marcar la entidad como modificada para que Entity Framework la actualice en la base de datos
            _context.Entry(Usage).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        

        
    }

}