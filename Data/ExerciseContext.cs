using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using Microsoft.Extensions.Configuration;

namespace BackEnd.Data
{

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

             modelBuilder.Entity<Amigo>()
                .HasKey(f => new { f.AmigoId });


            modelBuilder.Entity<Exercise>().HasData(

            new Exercise { ExerciseId = 1, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Posesion por equipos", Descripcion = "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 person…", Material = "material1, material2, material3 ,material4", Imagen = "posesion.gif" },
            new Exercise { ExerciseId = 2, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Las 4 esquinas", Descripcion = "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jug…", Material = "material1, material2", Imagen = "Pfi-0009bas.gif" },
            new Exercise { ExerciseId = 3, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rondo de pases y velocidad", Descripcion = "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasando…", Material = "material1, material2, material3", Imagen = "3.gif" },
            new Exercise { ExerciseId = 4, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Pañuelito con balón", Descripcion = "Cuando el entrenador diga un número saldrá un jugador de cada equipo C…", Material = "material1, material2, material3", Imagen = "4.gif" },
            new Exercise { ExerciseId = 5, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Velocidad", Descripcion = "Pase frontal entre 2 jugadores Una vez realizado el pase conducción co…", Material = "material1, material2, material3", Imagen = "5.gif" },
            new Exercise { ExerciseId = 6, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Caza por equipos", Descripcion = "2 equipos juegan a eliminarse Los jugadores tendrán el balón entre las…", Material = "material1, material2, material3", Imagen = "6.gif" },
            new Exercise { ExerciseId = 7, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Vaciar el campo", Descripcion = "Distribución de los jugadores en 2 campos y cada campo de dejará un ba…", Material = "material1, material2, material3", Imagen = "7.gif" },
            new Exercise { ExerciseId = 8, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Los 10 pases", Descripcion = "2 equipos formados por 5 jugadores cada uno juega un partido de posesi…", Material = "material1, material2, material3", Imagen = "8.gif" },
            new Exercise { ExerciseId = 9, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "La muralla", Descripcion = "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde …", Material = "material1, material2, material3", Imagen = "9.gif" },
            new Exercise { ExerciseId = 10, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Finalizaciones exteriores", Descripcion = "Se divide la frontal de la zona 3 areas diferentes En cada una de ella…", Material = "material1, material2", Imagen = "10.gif" },
            new Exercise { ExerciseId = 11, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rueda de contraataques", Descripcion = "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones…", Material = "material1, material2", Imagen = "11.gif" },
            new Exercise { ExerciseId = 12, Deporte = "Basket", Dificultad = "Hard", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Farlek a todo el campo", Descripcion = "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo El …", Material = "material1, material2", Imagen = "12.gif" },
            new Exercise { ExerciseId = 13, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Calentamiento", Nombre = "Calentamiento general dinámico", Descripcion = "En movimiento alrededor del campo se combinan: Trote, movilidad articu…", Material = "material1", Imagen = "13.gif" },
            new Exercise { ExerciseId = 14, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "2 contra 2 con apoyos exteriores", Descripcion = "Dos atacantes contra 2 defensores con 2 apoyos exteriores situados fue…", Material = "material1, material2", Imagen = "14.gif" },
            new Exercise { ExerciseId = 15, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Bloqueos verticales y ciegos", Descripcion = "Saque lateral en el que el base parte del poste bajo para salir a reci…", Material = "material1, material2, material3", Imagen = "15.gif" },
            new Exercise { ExerciseId = 16, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Fila de cojos", Descripcion = "Desplazarse en grupo coordinando el ritmo de movimiento Uno detrás del…", Material = "material1", Imagen = "16.gif" },
            new Exercise { ExerciseId = 17, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Sal del corro", Descripcion = "Intentar salir por los huecos que dejen los compañeros entre piernas, …", Material = "material1, material2", Imagen = "17.gif" },
            new Exercise { ExerciseId = 18, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito Abdominales 2", Descripcion = "1)Abdominal superior piernas extendidas 2)Abdominal inferior elevando …", Material = "material1, material2", Imagen = "18.gif" },
            new Exercise { ExerciseId = 19, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Medium", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito de coordinación", Descripcion = "1)Lanzar el balón de un brazo a otro por encima de la cabeza 2)Salto a…", Material = "material1, material2, material3, material4, material5", Imagen = "19.gif" },
            new Exercise { ExerciseId = 20, Deporte = "Basket", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de flexibilidad por parejas", Descripcion = "1)Elevación de pierna al pecho del compañero y buscar con ambas manos …", Material = "material1, material2, material3, material4", Imagen = "fexi2.gif" },
            new Exercise { ExerciseId = 21, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Defensa individual cada uno en su zona", Descripcion = "Se enfrentan 2 equipos de 3 jugadores cada uno Consiste en mantener la…", Material = "material1, material2, material3, material4", Imagen = "20.gif" },
            new Exercise { ExerciseId = 22, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Box horizontal y tiro exterior", Descripcion = "Partiendo en caja; (3) y (4) postes bajos, (5) y (1) postes altos El a…", Material = "material1, material2, material3", Imagen = "21.gif" },
            new Exercise { ExerciseId = 23, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Low", Personas = "Parejas", Objetivo = "Fisico", Nombre = "La silla adaptable", Descripcion = "Elevarse y descender sin ayuda de las manos Apoyarse uno con el ótro p…", Material = "material1", Imagen = "22.gif" },
            new Exercise { ExerciseId = 24, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito de Flexibilidad", Descripcion = "1)Apertura lateral de ambas piernas e inclinación del tronco hacia del…", Material = "material1, material2, material3, material4", Imagen = "fexi.gif" },
            new Exercise { ExerciseId = 25, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "¿Quien tocará el pivote?", Descripcion = "Consiste en evitar tocar el pivote Los jugadores se posicionan en círc…", Material = "material1, material2", Imagen = "23.gif" },
            new Exercise { ExerciseId = 26, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Te robo la casa", Descripcion = "Los jugadores se colocan formando un círculo Un jugador se desplaza a …", Material = "material1", Imagen = "24.gif" },
            new Exercise { ExerciseId = 27, Deporte = "Basket", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Defensa 2x2", Descripcion = "Se colocan en las esquinas del medio del campo Se empieza en una línea…", Material = "material1, material2", Imagen = "25.gif" },
            new Exercise { ExerciseId = 28, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Contrataque de 11", Descripcion = "Tres jugadores en el centro del campo empezarán atacando Dos jugadores…", Material = "material1, material2, material3", Imagen = "vuel.gif" },
            new Exercise { ExerciseId = 29, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Número y corre", Descripcion = "Consiste en llegar lo antes posible a uno de los 4 pivotes Los pivotes…", Material = "material1, material2", Imagen = "9.gif" },
            new Exercise { ExerciseId = 30, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Puntuación global 1x1", Descripcion = "Se juegan situaciones 1 contra 1 en medio campo con el bojetivo de lle…", Material = "material1, material2", Imagen = "24.gif" },
            new Exercise { ExerciseId = 32, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Circuito de Velocidad", Descripcion = "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies…", Material = "material1, material2, material3, material4", Imagen = "Pfi-0050.gif" },
            new Exercise { ExerciseId = 33, Deporte = "Futbol", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Combinación interior", Descripcion = "Se divide a la plantilla en 2 equipos que juegan por mantener la poses…", Material = "material1, material2, material3", Imagen = "Glo-0014.gif" },
            new Exercise { ExerciseId = 34, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Balón viajero", Descripcion = "Se formará un círculo con todos los jugadores excepto uno que se coloc…", Material = "material1, material2", Imagen = "Pfi-0031.gif" },
            new Exercise { ExerciseId = 35, Deporte = "Futbol", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de brazos por parejas", Descripcion = "1)Elevación de brazos por encima de la cabeza con resistencia(hacia ab…", Material = "material1", Imagen = "Pfi-0037.gif" },
            new Exercise { ExerciseId = 36, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Individual", Objetivo = "Fisico", Nombre = "Circuito de Velocidad", Descripcion = "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies…", Material = "material1, material2, material3", Imagen = "Pfi-0050.gif" },
            new Exercise { ExerciseId = 38, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Fisico", Nombre = "Circuito de Abdmominales", Descripcion = "El circuito se realizará por repeticiones y se darán 3 vueltas al circ…", Material = "material1", Imagen = "Pfi-0029.gif" },
            new Exercise { ExerciseId = 39, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego de calentamiento", Descripcion = "En una zona delimitada por los pivotes se colocarán 5 jugadores,un bal…", Material = "material1", Imagen = "Pfi-0038.gif" },
            new Exercise { ExerciseId = 40, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de piernas por parejas", Descripcion = "1)Flexión y extensión de piernas con oposición 2)Intentar bajar al sue…", Material = "material1", Imagen = "Pfi-0047.gif" },
            new Exercise { ExerciseId = 41, Deporte = "Futbol", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Cambios de orientación", Descripcion = "Se divide el terreno de juego en 3 zonas dentro de cada zona se sitúan…", Material = "material1, material2", Imagen = "Esp(centrocamp)-0001" },
            new Exercise { ExerciseId = 42, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Posesión 3 colores", Descripcion = "Dividir a la plantilla en tres equipos 2 equipos juegan dentro del cam…", Material = "material1, material2, material3", Imagen = "Glo-0012.gif" },
            new Exercise { ExerciseId = 43, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Fisico", Nombre = "Circuito Fisico- Técnico", Descripcion = "1)Carrera en sprint hasta la 1ªseñal vuelta recuperando, sprint hasta …", Material = "material1, material2", Imagen = "Pfi-0035.gif" },
            new Exercise { ExerciseId = 44, Deporte = "Futbol", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Partido 6 porterías", Descripcion = "Dividir a la plantilla en 2 equipos Cada equipo defiende-ataca 3 porte…", Material = "material1, material2, material3, material4", Imagen = "Glo-0001.gif" },
            new Exercise { ExerciseId = 45, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego corto 4 contra 4", Descripcion = "Dividir a la plantilla en equipos de 4 jugadores Partido en espacio re…", Material = "material1, material2, material3, material4", Imagen = "Glo-0002.gif" },
            new Exercise { ExerciseId = 46, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Partido medio campo 7x7", Descripcion = "Dividir la plantilla en 2 equipos Jugar 7x7 más 2 porteros Establecer …", Material = "material1, material2, material3, material4", Imagen = "Glo-0010.gif" },
            new Exercise { ExerciseId = 47, Deporte = "Futbol", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego en 3 zonas", Descripcion = "Dividir a la plantila en 2 equipos Cada equipo mantendrá un jugador en…", Material = "material1, material2, material3, material4", Imagen = "Glo-0011.gif" },
            new Exercise { ExerciseId = 48, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego corto con la cabeza", Descripcion = "Se divide a la plantilla en dos equipos Dentro del campo juegan 4 x 4 …", Material = "material1, material2, material3, material4", Imagen = "Glo-0005.gif" },
            new Exercise { ExerciseId = 49, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Parejas", Objetivo = "Fisico", Nombre = "La silla adaptable", Descripcion = "Elevarse y descender sin ayuda de las manos Apoyarse uno con el otro p…", Material = "material1, material2, material3, material4", Imagen = "Pfi-0002.gif" },
            new Exercise { ExerciseId = 50, Deporte = "Futbol", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "La fila que se empuja", Descripcion = "Dos filas con los jugadores colocados espalda contra espalda y con los…", Material = "material1", Imagen = "Pfi-0026.gif" }



            );



            /* modelBuilder.Entity<AsientosExercise>().HasData(
                            CreateAsientosExercise(1).ToList() // Crea una nueva Asiento con AsientoId = 1 y Reservado = false
                        ); */

            modelBuilder.Entity<User>().HasData(
                            new User { UserId = 1, Name = "Admin", Email = "admin@gmail.com", Password = "admin", Apellidos = "admin", Frase = "admin", Plan = "Pro" },
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
                            new Plan { PlanId = 1, Planes = "Basico", Price = "Gratis", Descripcion = "El plan Básico que permite a los usuarios visualizar diferentes ejercicios. Además, podrán seguir a otros usuarios y ver sus actividades", Precio = 0 },
                            new Plan { PlanId = 2, Planes = "Medium", Price = "4€", Descripcion = "El plan Medium ofrece a los usuarios poder ver TODOS los ejercicios que la aplicación ofrece. Se elimina la publicidad", Precio = 4 },
                            new Plan { PlanId = 3, Planes = "Pro", Price = "7€", Descripcion = "El plan Pro dispone de todas las ventajas del plan Medium, pero añade la funcionalidad de poder comentar y valorar los ejercicios. Además, permite crear ejercicios a los usuarios para aportar más información a la app.", Precio = 7 }

                        );

                         modelBuilder.Entity<Amigo>().HasData(
                            new Amigo { AmigoId = 1, Usuario = "admin@gmail.com", Amigos = "andrescabezon@gmail.com"},
                            new Amigo { AmigoId = 2, Usuario = "andrescabezon@gmail.com", Amigos = "belchite@gmail.com"},
                            new Amigo { AmigoId = 3, Usuario = "belchite@gmail.com", Amigos = "nikorx@gmail.com" }

                        );

        }

        public DbSet<Exercise> Exercises { get; set; }



        //public DbSet<AsientosExercise> AsientosExercises {get; set;}



        public DbSet<User> Users { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Amigo> Amigos { get; set; }
    }
}