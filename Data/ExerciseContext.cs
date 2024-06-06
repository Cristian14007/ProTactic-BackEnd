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
            
            modelBuilder.Entity<Usage>()
             .HasKey(d => new { d.UsageId });


            modelBuilder.Entity<Exercise>().HasData(

            new Exercise { ExerciseId = 1, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Posesion por equipos", Descripcion = "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 personas cada uno. \nUna vez tengamos listos los equipos, cada uno de los equipos intentará mantener la posesión el mayor tiempo posible.", Material = "material1, material2, material3 ,material4", Imagen = "posesion.gif" },
            new Exercise { ExerciseId = 2, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Las 4 esquinas", Descripcion = "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jugadores siempre quedarán fuera", Material = "material1, material2", Imagen = "Pfi-0009bas.gif" },
            new Exercise { ExerciseId = 3, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rondo de pases y velocidad", Descripcion = "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasandose el balón rápidamente \nLos jugadores de fuera llevan en la mano un peto A la señal del entrenador dejan caer el peto al suelo y se dirigen a coger los petos que han dejado los del otro rondo Los dos que no tienen peto juegan dentro del rondo", Material = "material1, material2, material3", Imagen = "3.gif" },
            new Exercise { ExerciseId = 4, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Pañuelito con balón", Descripcion = "Cuando el entrenador diga un número saldrá un jugador de cada equipo \nConsiste en coger el balón y conducirlo sin que el otro jugador le quite el balón", Material = "material1, material2, material3", Imagen = "4.gif" },
            new Exercise { ExerciseId = 5, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Velocidad", Descripcion = "Pase frontal entre 2 jugadores \nUna vez realizado el pase conducción con bote rápido en dirección al pivote \nEl poseedor del balón intentará llegar antes de que su compañero le coja \nEl jugador que persigue saldrá en el momento en el que su compañero", Material = "material1, material2, material3", Imagen = "5.gif" },
            new Exercise { ExerciseId = 6, Deporte = "Basket", Dificultad = "Low", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Caza por equipos", Descripcion = "2 equipos juegan a eliminarse \nLos jugadores tendrán el balón entre las manos y no podrán dar más de 3 pasos con él \nSerá eliminado un jugador cuando se le toque con el balón \nEl jugador que salga del campo delimitado también quedará eliminado", Material = "material1, material2, material3", Imagen = "6.gif" },
            new Exercise { ExerciseId = 7, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Vaciar el campo", Descripcion = "Distribución de los jugadores en 2 campos y cada campo de dejará un balón por jugador \nA la señal del entrenador los jugadores de cada equipo intentarán sacar los balones de su campo utilizando para ello tanto las manos,pies,...,mandándolos al campo \ncontrario \nGanará el equipo que en un minuto tenga menos balones en su campo", Material = "material1, material2, material3", Imagen = "7.gif" },
            new Exercise { ExerciseId = 8, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Los 10 pases", Descripcion = "2 equipos formados por 5 jugadores cada uno juega un partido de posesión con las manos \nEl objetivo será conseguir 10 pases seguidos sin ser interceptados \nEl equipo que consiga 10 pases seguidos logrará un punto \nGanará el equipo que consiga mayor número de puntos", Material = "material1, material2, material3", Imagen = "8.gif" },
            new Exercise { ExerciseId = 9, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "La muralla", Descripcion = "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde se situará un jugador \nEste procurará tocar a los jugadores que intentan pasar de un lado a otro \nSi éstos son tocados se quedarán en el pasillo y agarrados por la mano intentarán tocar al resto de sus compañeros", Material = "material1, material2, material3", Imagen = "9.gif" },
            new Exercise { ExerciseId = 10, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Finalizaciones exteriores", Descripcion = "Se divide la frontal de la zona 3 areas diferentes \nEn cada una de ellas el alero recibirá un pase de cada uno de los pasadores (diferentes posiciones) \nEl objetivo será finalizar en canasta el máximo nº de acciones posibles \nLos pases llegan desde diferentes alturas y direcciones por lo que será necesario el desplazamiento y la orientación corporal para finalizar con rapidez y eficacia", Material = "material1, material2", Imagen = "10.gif" },
            new Exercise { ExerciseId = 11, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Rueda de contraataques", Descripcion = "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones", Material = "material1, material2", Imagen = "11.gif" },
            new Exercise { ExerciseId = 12, Deporte = "Basket", Dificultad = "Hard", Edad = 7, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Farlek a todo el campo", Descripcion = "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo \nEl primer grupo realiza a velocidad (80%)la distancia de 6,25 a 6,25 m y despúes andando(recuperación) \nLos grupos van saliendo a modo de relevos (llega uno sale el otro)", Material = "material1, material2", Imagen = "12.gif" },
            new Exercise { ExerciseId = 13, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Calentamiento", Nombre = "Calentamiento general dinámico", Descripcion = "En movimiento alrededor del campo se combinan: Trote, movilidad articular, estiramientos,cambios de dirección y de ritmo", Material = "material1", Imagen = "13.gif" },
            new Exercise { ExerciseId = 14, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "2 contra 2 con apoyos exteriores", Descripcion = "Dos atacantes contra 2 defensores con 2 apoyos exteriores situados fuera de la línea de 6,25 \nSi los atacantes consiguen canasta los defensores siguen en su función y éstos cambian su función con los jugadores exteriores \nSi no consiguen canasta se quedan a defender frente al equipo exterior", Material = "material1, material2", Imagen = "14.gif" },
            new Exercise { ExerciseId = 15, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Bloqueos verticales y ciegos", Descripcion = "Saque lateral en el que el base parte del poste bajo para salir a recibir al exterior \nEl base se desplaza hacia el lado contrario para realizar un pick and roll con el poste alto (4) \nEl (3) realiza un bloqueo ciego al defensor del (5) y corta la zona hacia el poste alto \nEl (4) tras realizar el pick and roll realiza un bloqueo vertical al defensor del (3) \nSe buscan dos posibles finalizaciones: a)Pase y finalización exterior por parte del (3). b)Pase interior y finalización 1x1 del (5)", Material = "material1, material2, material3", Imagen = "15.gif" },
            new Exercise { ExerciseId = 16, Deporte = "Basket", Dificultad = "Medium", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Fila de cojos", Descripcion = "Desplazarse en grupo coordinando el ritmo de movimiento \nUno detrás del ótro agarra la pierna del compañero \nApoyarse uno con el ótro por la espalda", Material = "material1", Imagen = "16.gif" },
            new Exercise { ExerciseId = 17, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Sal del corro", Descripcion = "Intentar salir por los huecos que dejen los compañeros entre piernas, brazos o por encima", Material = "material1, material2", Imagen = "17.gif" },
            new Exercise { ExerciseId = 18, Deporte = "Basket", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito Abdominales 2", Descripcion = "1)Abdominal superior piernas extendidas \n2)Abdominal inferior elevando alternativamente las piernas extendidas \n3)Oblicuos mediante inclinaciones laterales de tronco \n4)Lumbares con elevación de tronco con el tren inferior apoyado \n5)Abdominal inferior mediante flexión- extensión de piernas simultáneamente a ras de suelo \n6)Abdominal superior con elevación de piernas a 90 º \nRealizar 2 Vueltas completas al circuitoColocarse cogidos de la mano y dentro un jugador", Material = "material1, material2", Imagen = "18.gif" },
            new Exercise { ExerciseId = 19, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Medium", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito de coordinación", Descripcion = "1)Lanzar el balón de un brazo a otro por encima de la cabeza \n2)Salto a la comba con pies juntos \n3)Rotación de brazos(uno hacia delante, el otro hacia atrás) \n4ª)Dominios de balón por el aire \n5)Realizar el pino(con o sin apoyo) \n6)Desplazamiento de espaldas en zig-zag \nRealizar 2 Vueltas completas al circuito", Material = "material1, material2, material3, material4, material5", Imagen = "19.gif" },
            new Exercise { ExerciseId = 20, Deporte = "Basket", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de flexibilidad por parejas", Descripcion = "1)Elevación de pierna al pecho del compañero y buscar con ambas manos puntera y pie apoyado \n2)Apertura lateral de ambas piernas y flexión del tronco hacia delante con ayuda \n3)Ambos compañeros con apertura lateral de ambas piernas y agarrados por las manos tratando de juntar las pelvis \n4)Tumbado boca abajo elevación de una pierna hacia atrás \n5)Tumbado boca abajo elevación de tronco \n6)Tumbado boca arriba llevar ambas piernas hacia el tronco", Material = "material1, material2, material3, material4", Imagen = "fexi2.gif" },
            new Exercise { ExerciseId = 21, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Defensa individual cada uno en su zona", Descripcion = "Se enfrentan 2 equipos de 3 jugadores cada uno \nConsiste en mantener la posesión del balón con la ayuda de los dos jugadores que se encuentran fuera del espacio de juego (pivotes) \nEl resto jugarán cada uno en su zona delimitada, que no podrán abandonar", Material = "material1, material2, material3, material4", Imagen = "20.gif" },
            new Exercise { ExerciseId = 22, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Box horizontal y tiro exterior", Descripcion = "Partiendo en caja; (3) y (4) postes bajos, (5) y (1) postes altos El a…", Material = "material1, material2, material3", Imagen = "21.gif" },
            new Exercise { ExerciseId = 23, Deporte = "Basket", Dificultad = "Low", Edad = 14, Intensidad = "Low", Personas = "Parejas", Objetivo = "Fisico", Nombre = "La silla adaptable", Descripcion = "Elevarse y descender sin ayuda de las manos \nApoyarse uno con el ótro por la espalda", Material = "material1", Imagen = "22.gif" },
            new Exercise { ExerciseId = 24, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Estiramiento", Nombre = "Circuito de Flexibilidad", Descripcion = "1)Apertura lateral de ambas piernas e inclinación del tronco hacia delante buscando las punteras \n2)Fondos de brazos(realizando la lagartija) \n3)Extensión de cuadriceps en equilibrio sobre 1 pierna \n4)De cuclillas estiramiento lateral de una piern \n5)De rodillas inclinación del tronco hacia delante-atrás \n6)Posición del salto de valla buscando las punteras \nRealizar 2 vueltas completas al circuito", Material = "material1, material2, material3, material4", Imagen = "fexi.gif" },
            new Exercise { ExerciseId = 25, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "¿Quien tocará el pivote?", Descripcion = "Consiste en evitar tocar el pivote \nLos jugadores se posicionan en círculo con un pivote en la mitad \nDan vueltas en una dirección y a la señal intentarán traccionar a todos sus compañeros hacia atrás para que uno de éllos toque con cualquier parte del cuerpo el pivote \nEl jugador que lo haya tocado quedará eliminado", Material = "material1, material2", Imagen = "23.gif" },
            new Exercise { ExerciseId = 26, Deporte = "Basket", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Te robo la casa", Descripcion = "Los jugadores se colocan formando un círculo \nUn jugador se desplaza a trote por el exterior \nA la voz del entrenador el jugador que se encuentra a su altura debe intentar cogerle antes de que el jugador exterior pueda ocupar su sitio tras dar una vuelta \ncompleta al círculo", Material = "material1", Imagen = "24.gif" },
            new Exercise { ExerciseId = 27, Deporte = "Basket", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Defensa 2x2", Descripcion = "Se colocan en las esquinas del medio del campo \nSe empieza en una línea de fondo \nLos defensores deberán esprintar para llegar a tiempo", Material = "material1, material2", Imagen = "25.gif" },
            new Exercise { ExerciseId = 28, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Contrataque de 11", Descripcion = "Tres jugadores en el centro del campo empezarán atacando \nDos jugadores se colocarán en cada zona como defensores y otros 2 en cada mitad de campo \nAtacan 3 para 2 y van todos al rebote \nEl que coja el rebote pasa rápidamente a uno de los que esperan en las bandas \nEl que cogió el rebote y los 2 jugadores que esperaban se organizan para atacar al otro aro \nLos 4 que se quedan se reparten:2 defienden y 2 esperan en las bandas", Material = "material1, material2, material3", Imagen = "vuel.gif" },
            new Exercise { ExerciseId = 29, Deporte = "Basket", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Número y corre", Descripcion = " Consiste en llegar lo antes posible a uno de los 4 pivotes \nLos pivotes estarán numerados \nA la señal del entrenador los jugadores se dirigirán al pivote que él haya nombrado \nEl último en llegar quedará elimindo", Material = "material1, material2", Imagen = "9.gif" },
            new Exercise { ExerciseId = 30, Deporte = "Basket", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Puntuación global 1x1", Descripcion = "Se juegan situaciones 1 contra 1 en medio campo con el objetivo de llegar a un nº determinado de puntos (7)", Material = "material1, material2", Imagen = "24.gif" },
            new Exercise { ExerciseId = 32, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Circuito de Velocidad", Descripcion = "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies entre pica y pica con aceleración \n3)Carrera en sprint mediante zig- zag \n4)Ampliar la zancada progresivamente 1 apoyo entre pica y pica \n5)Saltos a pies juntos por encima de las vallas y aceleración \n6)Amplitud introduciendo una pierna en cada aro", Material = "material1, material2, material3, material4", Imagen = "Pfi-0050.gif" },
            new Exercise { ExerciseId = 33, Deporte = "Futbol", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Combinación interior", Descripcion = "Se divide a la plantilla en 2 equipos que juegan por mantener la posesión del balón \nEn la zona (recuadro) marcado únicamente podrá entrar un jugador por equipo \nSe conseguirá un tanto a favor cuando un equipo sea capaz de realizar una combinación de pase y devolución con uno de sus jugadores que previamente haya entrado en \ndicha zona \nNo se puede permanecer en la zona de marca", Material = "material1, material2, material3", Imagen = "Glo-0014.gif" },
            new Exercise { ExerciseId = 34, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "Balón viajero", Descripcion = "Se formará un círculo con todos los jugadores excepto uno que se colocará en el exterior del círculo \nLos jugadores que están situados en círculo se pasan un balón mientrás que el jugador exterior debe de correr hasta interceptarlo \nAl jugador que se le haya interceptado el balón se colocará en el exterior \nUna distancia entre jugador y jugador de 3 metros", Material = "material1, material2", Imagen = "Pfi-0031.gif" },
            new Exercise { ExerciseId = 35, Deporte = "Futbol", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de brazos por parejas", Descripcion = "1)Elevación de brazos por encima de la cabeza con resistencia(hacia abajo) \n2)Fondos de brazos con resistencia \n3)Avanzar haciendo la carretilla \n4)Empujar uno contra otro con brazos extendidos \n5)Pulso en el suelo con apoyo de 1 brazo \n6)Juntar los brazos al cuerpo con resistencia(hacia arriba) \nRealizar 2 vueltas completas al circuito:1ª)30” de acción 30” de recuperación", Material = "material1", Imagen = "Pfi-0037.gif" },
            new Exercise { ExerciseId = 36, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Individual", Objetivo = "Fisico", Nombre = "Circuito de Velocidad", Descripcion = "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies entre pica y pica con aceleración \n3)Carrera en sprint mediante zig- zag \n4)Ampliar la zancada progresivamente 1 apoyo entre pica y pica \n5)Saltos a pies juntos por encima de las vallas y aceleración \n6)Amplitud introduciendo una pierna en cada aro", Material = "material1, material2, material3", Imagen = "Pfi-0050.gif" },
            new Exercise { ExerciseId = 38, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Individual", Objetivo = "Fisico", Nombre = "Circuito de Abdmominales", Descripcion = "El circuito se realizará por repeticiones y se darán 3 vueltas al circuito \n1ª) 20 repeticiones por posta 2ª) 15 repeticiones por posta 3ª) 10 repeticiones por posta \nSe recuperará aproximadamente 30 entre posta y posta \nPostas: 1-Abd.dorsal 2-Lumbares con elevación de piernas 3-Abd.inferior con elevación de piernas 4-Abd. superior piernas extendidas 5-Lumbares con elevación de \ntronco 6-Abd.superior con piernas semiflexionadas", Material = "material1", Imagen = "Pfi-0029.gif" },
            new Exercise { ExerciseId = 39, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego de calentamiento", Descripcion = "En una zona delimitada por los pivotes se colocarán 5 jugadores,un balón por jugador y 5 pivotes", Material = "material1", Imagen = "Pfi-0038.gif" },
            new Exercise { ExerciseId = 40, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Estiramiento", Nombre = "Circuito de piernas por parejas", Descripcion = "1)Flexión y extensión de piernas con oposición \n2)Intentar bajar al suelo frente a la oposición la pierna extendida \n3)Avanzar cargando a burros con el compañero \n4)Saltos por encima del compañero agachado \n5)Flexión-extensión simultánea de las piernas(con oposición),con la espalda apoyada en el suelo \n6)Resistencia a la carrera con agarre por la cintura", Material = "material1", Imagen = "Pfi-0047.gif" },
            new Exercise { ExerciseId = 41, Deporte = "Futbol", Dificultad = "Hard", Edad = 14, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Cambios de orientación", Descripcion = "Se divide el terreno de juego en 3 zonas \ndentro de cada zona se sitúan 2 jugadores ofensivos y 1 jugador defensivo \nEl objetivo será realizar cambios de orientación continuos obligando a que el balón pase por ambas bandas \nCada vez que se consiga un cambio de orientación completo se conseguirá un punto \nLos defensores deben presionar en su zona a los dos jugadores atacantes", Material = "material1, material2", Imagen = "Esp(centrocamp)-0001.gif" },
            new Exercise { ExerciseId = 42, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Posesión 3 colores", Descripcion = "Dividir a la plantilla en tres equipos \n2 equipos juegan dentro del campo y el otro equipo se sitúa como apoyo exterior \nLos dos equipos interiores luchan por mantener la posesión del balón para lo que se pueden apoyar en los jugadores que se encuentran en el exterior \nCada 8 o 10 min cambiar el equipo exterior por uno de los interiores", Material = "material1, material2, material3", Imagen = "Glo-0012.gif" },
            new Exercise { ExerciseId = 43, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Parejas", Objetivo = "Fisico", Nombre = "Circuito Fisico- Técnico", Descripcion = "1)Carrera en sprint hasta la 1ªseñal vuelta recuperando, sprint hasta …", Material = "material1, material2", Imagen = "Pfi-0035.gif" },
            new Exercise { ExerciseId = 44, Deporte = "Futbol", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Partido 6 porterías", Descripcion = "Dividir a la plantilla en 2 equipos \nCada equipo defiende-ataca 3 porterías pequeñas situadas a lo largo de la línea de fondo \nEl gol se conseguirá introduciendo el balón en cualquiera de las 3 porterías", Material = "material1, material2, material3, material4", Imagen = "Glo-0001.gif" },
            new Exercise { ExerciseId = 45, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego corto 4 contra 4", Descripcion = "Dividir a la plantilla en equipos de 4 jugadores \nPartido en espacio reducido entre 2 equipos \nCombinar apoyos, paredes, regates,...para meter gol \nEl juego se desarrollará con máxima intensidad", Material = "material1, material2, material3, material4", Imagen = "Glo-0002.gif" },
            new Exercise { ExerciseId = 46, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Partido medio campo 7x7", Descripcion = "Dividir la plantilla en 2 equipos \nJugar 7x7 más 2 porteros \nEstablecer objetivos tácticos según necesidades;pressing, repliegue, cambios de orientación..", Material = "material1, material2, material3, material4", Imagen = "Glo-0010.gif" },
            new Exercise { ExerciseId = 47, Deporte = "Futbol", Dificultad = "Hard", Edad = 18, Intensidad = "Hard", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego en 3 zonas", Descripcion = "Dividir a la plantila en 2 equipos \nCada equipo mantendrá un jugador en su zona defensiva que no podrá salir de ésta \nPara marcar gol tendrán 2 posibilidades:Tirar sobre la portería defendida por el portero ó conducir a través de los conos", Material = "material1, material2, material3, material4", Imagen = "Glo-0011.gif" },
            new Exercise { ExerciseId = 48, Deporte = "Futbol", Dificultad = "Medium", Edad = 14, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Calentamiento", Nombre = "Juego corto con la cabeza", Descripcion = "Se divide a la plantilla en dos equipos \nDentro del campo juegan 4 x 4 ó 5 x 5 (+ 2 porteros), en los fondos y en los laterales de las porterías se colocan jugadores del equipo que ataca \nSe juega en todo momento con la cabeza y únicamente puede cogerse el balón con la mano despues de un bote \nCada 3 o 4 minutos se cambian los jugadores que realizan los apoyos exteriores", Material = "material1, material2, material3, material4", Imagen = "Glo-0005.gif" },
            new Exercise { ExerciseId = 49, Deporte = "Futbol", Dificultad = "Low", Edad = 7, Intensidad = "Low", Personas = "Parejas", Objetivo = "Fisico", Nombre = "La silla adaptable", Descripcion = "Elevarse y descender sin ayuda de las manos \nApoyarse uno con el ótro por la espalda", Material = "material1, material2, material3, material4", Imagen = "Pfi-0002.gif" },
            new Exercise { ExerciseId = 50, Deporte = "Futbol", Dificultad = "Medium", Edad = 7, Intensidad = "Medium", Personas = "Grupos", Objetivo = "Fisico", Nombre = "La fila que se empuja", Descripcion = "Dos filas con los jugadores colocados espalda contra espalda y con los brazos entrelazados intentan empujar", Material = "material1", Imagen = "Pfi-0026.gif" }



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

                        modelBuilder.Entity<Usage>().HasData(
                            new Usage { UsageId = 1, Month = "January", Futbol = 32, Basket = 28, Basico = 30, Medium = 15, Pro = 5, Clientes = 50 },
                            new Usage { UsageId = 2, Month = "February", Futbol = 30, Basket = 28, Basico = 25, Medium = 20, Pro = 5, Clientes = 50 },
                            new Usage { UsageId = 3, Month = "March", Futbol = 35, Basket = 29, Basico = 30, Medium = 18, Pro = 7, Clientes = 55 },
                            new Usage { UsageId = 4, Month = "April", Futbol = 40, Basket = 37, Basico = 33, Medium = 25, Pro = 7, Clientes = 65 },
                            new Usage { UsageId = 5, Month = "May", Futbol = 50, Basket = 50, Basico = 40, Medium = 20, Pro = 10, Clientes = 70 },
                            new Usage { UsageId = 6, Month = "June", Futbol = 70, Basket = 63, Basico = 50, Medium = 25, Pro = 15, Clientes = 90 },
                            new Usage { UsageId = 7, Month = "July", Futbol = 80, Basket = 75, Basico = 65, Medium = 27, Pro = 23, Clientes = 105 },
                            new Usage { UsageId = 8, Month = "August", Futbol = 92, Basket = 87, Basico = 70, Medium = 20, Pro = 30, Clientes = 120 },
                            new Usage { UsageId = 9, Month = "September", Futbol = 60, Basket = 54, Basico = 50, Medium = 15, Pro = 10, Clientes = 75 },
                            new Usage { UsageId = 10, Month = "October", Futbol = 35, Basket = 40, Basico = 50, Medium = 10, Pro = 10, Clientes = 70 },
                            new Usage { UsageId = 11, Month = "November", Futbol = 30, Basket = 27, Basico = 45, Medium = 10, Pro = 10, Clientes = 65 },
                            new Usage { UsageId = 12, Month = "Dicember", Futbol = 32, Basket = 35, Basico = 45, Medium = 5, Pro = 10, Clientes = 60 }
                            
                        );

        }

        public DbSet<Exercise> Exercises { get; set; }



        //public DbSet<AsientosExercise> AsientosExercises {get; set;}



        public DbSet<User> Users { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Amigo> Amigos { get; set; }

        public DbSet<Usage> Usages { get; set; }
    }
}