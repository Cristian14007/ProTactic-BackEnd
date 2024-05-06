using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{

    public class PlanEFRepository : IPlanRepository{

         private readonly ExerciseContext _context;

       

        public PlanEFRepository(ExerciseContext context){
            _context = context;
           
        }

        public void Add(Plan Plan)
        {
            _context.Plans.Add(Plan); 
            SaveChanges();

          
        }

        public void Delete(int id)
        {
            
            var PlanDto = Get(id);
            if (PlanDto == null)
            {
                throw new KeyNotFoundException("Plan not found.");
            }

            var Plan = _context.Plans.FirstOrDefault(o => o.PlanId == id);
            if (Plan != null)
            {
                _context.Plans.Remove(Plan);
                SaveChanges();
            }

        }

       public PlanGetDTO Get(int id)
        {
            var Plan = _context.Plans
                .Where(Plan => Plan.PlanId == id)
                .FirstOrDefault();

            if (Plan != null)
            {
                var PlanGetDTO = new PlanGetDTO
                {
                    PlanId = Plan.PlanId,
                    Planes = Plan.Planes,
                    Price = Plan.Price,
                    Descripcion = Plan.Descripcion,
                    Precio = Plan.Precio
                    
                };

                return PlanGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }

        }

        

        public List<PlanGetDTO> GetAll()
        {
            var Plans = _context.Plans
                .ToList();

            if (Plans != null)
            {
                var PlanGetDTO = Plans.Select(e => new PlanGetDTO
                {
                    PlanId = e.PlanId,
                    Planes = e.Planes,
                    Price = e.Price,
                    Descripcion = e.Descripcion,
                    Precio = e.Precio
                }).ToList();
                return PlanGetDTO;
            }
            else
            {
                return null; // Devuelve null si no se encuentra la obra
            }
        }

        public void Update(Plan Plan)
        {
            // Verificar si ya hay una instancia de Plan con el mismo PlanId en el contexto
            var existingPlan = _context.Plans.Find(Plan.PlanId);

            if (existingPlan != null)
            {
                // Si existe una instancia previa, desvincularla del contexto
                _context.Entry(existingPlan).State = EntityState.Detached;
            }

            // Adjuntar la nueva instancia de Plan al contexto
            _context.Attach(Plan);

            // Marcar la entidad como modificada para que Entity Framework la actualice en la base de datos
            _context.Entry(Plan).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        

        
    }

}