using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Data{

    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options)
            : base(options)
            {

            }

        
        /* public List<AsientosExercise> CreateAsientosExercise(int exerciseId)
        {
            List<AsientosExercise> asientos = new List<AsientosExercise>();

            for (int i = 1; i <= 25; i++)
            {
                asientos.Add(new AsientosExercise
                {
                    AsientoId = i,
                    ExerciseId = exerciseId,
                    Reservado = false
                });
            }

            return asientos;
        } */

       

            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Exercise>()

            .HasKey(a => a.ExerciseId);

            modelBuilder.Entity<User>()
                .HasKey(u => new { u.UserId });

            modelBuilder.Entity<Plan>()
             .HasKey(e => new { e.PlanId });

            
modelBuilder.Entity<Exercise>().HasData(

    new Exercise { ExerciseId = 1, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Posesion por equipos", Descripcion = "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 person…", Material = "material1, material2, material3 ,material4", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
    new Exercise { ExerciseId = 2, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Las 4 esquinas", Descripcion = "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jug…", Material = "material1, material2", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 3, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rondo de pases y velocidad", Descripcion = "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasando…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 4, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Pañuelito con balón", Descripcion = "Cuando el entrenador diga un número saldrá un jugador de cada equipo C…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 5, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Velocidad", Descripcion = "Pase frontal entre 2 jugadores Una vez realizado el pase conducción co…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 6, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Caza por equipos", Descripcion = "2 equipos juegan a eliminarse Los jugadores tendrán el balón entre las…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 7, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Vaciar el campo", Descripcion = "Distribución de los jugadores en 2 campos y cada campo de dejará un ba…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 8, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Los 10 pases", Descripcion = "2 equipos formados por 5 jugadores cada uno juega un partido de posesi…", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 9, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "La muralla", Descripcion = "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde …", Material = "material1, material2, material3", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 10, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Finalizaciones exteriores", Descripcion = "Se divide la frontal de la zona 3 areas diferentes En cada una de ella…", Material = "material1, material2", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 11, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rueda de contraataques", Descripcion = "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones…", Material = "material1, material2", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" },
new Exercise { ExerciseId = 12, Deporte = "Basket", Dificultad = "Hard", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Farlek a todo el campo", Descripcion = "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo El …", Material = "material1, material2", Imagen = "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…" }



    
);



/* modelBuilder.Entity<AsientosExercise>().HasData(
                CreateAsientosExercise(1).ToList() // Crea una nueva Asiento con AsientoId = 1 y Reservado = false
            ); */

modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Admin", Email = "admin@gmail.com", Password = "admin", Apellidos= "admin", Frase="admin", Plan="Pro" },
                new User { UserId = 2, Name = "Andrelo", Email = "andrescabezon@gmail.com", Password = "1234", Apellidos = "Torres Berraquero", Frase = "Nunca digas nunca!! 😜", Plan = "Pro" },
                new User { UserId = 3, Name = "Gabolon", Email = "gabolon@gmail.com", Password = "123", Apellidos = "Mearte Tiberio", Frase = "Ahi con las requetonas!!", Plan = "Basico" },
                new User { UserId = 4, Name = "Cristian", Email = "belchite@gmail.com", Password = "12345", Apellidos = "Ezquerra Belchite", Frase = "Soy muy vago!!", Plan = "Basico" },
                new User { UserId = 5, Name = "Niko", Email = "nikorx@gmail.com", Password = "33", Apellidos = "Gutierrez Ramon", Frase = "Tomate pero unas vacaciones", Plan = "Pro" },
                new User { UserId = 6, Name = "Cristian", Email = "blancash@gmail.com", Password = "33", Apellidos = "Blancash Sara", Frase = "Enamorado de la vida!! 😜", Plan = "Medium" },
                new User { UserId = 7, Name = "Toño", Email = "antonion@gmail.com", Password = "33", Apellidos = "Panchez Esteban", Frase = "Me gusta quejarme", Plan = "Basico" },
                new User { UserId = 8, Name = "Gabo", Email = "1@gmail.com", Password = "1", Apellidos = "Eres Ungenio", Frase = "Hey there! I'm using Pro-Tactic", Plan = "Basico" },
                new User { UserId = 9, Name = "3", Email = "2@gmail.com", Password = "2", Apellidos = "33", Frase = "Hey there! I'm using Pro-Tactic", Plan = "Pro" },
                new User { UserId = 10, Name = "Andres", Email = "Atorres@gmail.com", Password = "1", Apellidos = "Torres Berraquero", Frase = "Hey there! I'm using Pro-Tactic", Plan = "Basico" },
                new User { UserId = 11, Name = "Andresito", Email = "Andres@gmail.com", Password = "1", Apellidos = "Torres Berraquero", Frase = "Hey there! I'm using Pro-Tactic", Plan = "Pro" },
                new User { UserId = 12, Name = "pruebaFinal", Email = "prueba@gmail.com", Password = "123", Apellidos = "prueba prueba", Frase = "Hey there! I'm using Pro-Tactic", Plan = "Basico" }
            );

modelBuilder.Entity<Plan>().HasData(
                new Plan { PlanId = 1, Planes = "Basico", Price = "Gratis", Descripcion="El plan Básico que permite a los usuarios visualizar diferentes ejercicios. Además, podrán seguir a otros usuarios y ver sus actividades", Precio=0 },
                new Plan { PlanId = 2, Planes = "Medium", Price = "4€", Descripcion="El plan Medium ofrece a los usuarios poder ver TODOS los ejercicios que la aplicación ofrece. Se elimina la publicidad", Precio=4 },
                new Plan { PlanId = 3, Planes = "Pro", Price = "7€", Descripcion="El plan Pro dispone de todas las ventajas del plan Medium, pero añade la funcionalidad de poder comentar y valorar los ejercicios. Además, permite crear ejercicios a los usuarios para aportar más información a la app.", Precio=7 }
                
            );

        }

        public DbSet<Exercise> Exercises {get; set;}



        //public DbSet<AsientosExercise> AsientosExercises {get; set;}



        public DbSet<User> Users { get; set;}

        public DbSet<Plan> Plans { get; set;}
    }
}