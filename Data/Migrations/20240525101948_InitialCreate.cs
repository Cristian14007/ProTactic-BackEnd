using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    AmigoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amigos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => x.AmigoId);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dificultad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intensidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Planes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Usages",
                columns: table => new
                {
                    UsageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Futbol = table.Column<int>(type: "int", nullable: false),
                    Basket = table.Column<int>(type: "int", nullable: false),
                    Basico = table.Column<int>(type: "int", nullable: false),
                    Medium = table.Column<int>(type: "int", nullable: false),
                    Pro = table.Column<int>(type: "int", nullable: false),
                    Clientes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usages", x => x.UsageId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Amigos",
                columns: new[] { "AmigoId", "Amigos", "Usuario" },
                values: new object[,]
                {
                    { 1, "andrescabezon@gmail.com", "admin@gmail.com" },
                    { 2, "belchite@gmail.com", "andrescabezon@gmail.com" },
                    { 3, "nikorx@gmail.com", "belchite@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Deporte", "Descripcion", "Dificultad", "Edad", "Imagen", "Intensidad", "Material", "Nombre", "Objetivo", "Personas" },
                values: new object[,]
                {
                    { 1, "Basket", "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 personas cada uno. \nUna vez tengamos listos los equipos, cada uno de los equipos intentará mantener la posesión el mayor tiempo posible.", "Low", 7, "posesion.gif", "Hard", "material1, material2, material3 ,material4", "Posesion por equipos", "Calentamiento", "Grupos" },
                    { 2, "Basket", "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jugadores siempre quedarán fuera", "Low", 7, "Pfi-0009bas.gif", "Low", "material1, material2", "Las 4 esquinas", "Calentamiento", "Grupos" },
                    { 3, "Basket", "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasandose el balón rápidamente \nLos jugadores de fuera llevan en la mano un peto A la señal del entrenador dejan caer el peto al suelo y se dirigen a coger los petos que han dejado los del otro rondo Los dos que no tienen peto juegan dentro del rondo", "Low", 7, "3.gif", "Hard", "material1, material2, material3", "Rondo de pases y velocidad", "Calentamiento", "Grupos" },
                    { 4, "Basket", "Cuando el entrenador diga un número saldrá un jugador de cada equipo \nConsiste en coger el balón y conducirlo sin que el otro jugador le quite el balón", "Low", 14, "4.gif", "Low", "material1, material2, material3", "Pañuelito con balón", "Calentamiento", "Grupos" },
                    { 5, "Basket", "Pase frontal entre 2 jugadores \nUna vez realizado el pase conducción con bote rápido en dirección al pivote \nEl poseedor del balón intentará llegar antes de que su compañero le coja \nEl jugador que persigue saldrá en el momento en el que su compañero", "Low", 18, "5.gif", "Hard", "material1, material2, material3", "Velocidad", "Calentamiento", "Grupos" },
                    { 6, "Basket", "2 equipos juegan a eliminarse \nLos jugadores tendrán el balón entre las manos y no podrán dar más de 3 pasos con él \nSerá eliminado un jugador cuando se le toque con el balón \nEl jugador que salga del campo delimitado también quedará eliminado", "Low", 18, "6.gif", "Hard", "material1, material2, material3", "Caza por equipos", "Calentamiento", "Grupos" },
                    { 7, "Basket", "Distribución de los jugadores en 2 campos y cada campo de dejará un balón por jugador \nA la señal del entrenador los jugadores de cada equipo intentarán sacar los balones de su campo utilizando para ello tanto las manos,pies,...,mandándolos al campo \ncontrario \nGanará el equipo que en un minuto tenga menos balones en su campo", "Medium", 18, "7.gif", "Medium", "material1, material2, material3", "Vaciar el campo", "Calentamiento", "Grupos" },
                    { 8, "Basket", "2 equipos formados por 5 jugadores cada uno juega un partido de posesión con las manos \nEl objetivo será conseguir 10 pases seguidos sin ser interceptados \nEl equipo que consiga 10 pases seguidos logrará un punto \nGanará el equipo que consiga mayor número de puntos", "Medium", 18, "8.gif", "Medium", "material1, material2, material3", "Los 10 pases", "Calentamiento", "Grupos" },
                    { 9, "Basket", "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde se situará un jugador \nEste procurará tocar a los jugadores que intentan pasar de un lado a otro \nSi éstos son tocados se quedarán en el pasillo y agarrados por la mano intentarán tocar al resto de sus compañeros", "Medium", 18, "9.gif", "Medium", "material1, material2, material3", "La muralla", "Calentamiento", "Grupos" },
                    { 10, "Basket", "Se divide la frontal de la zona 3 areas diferentes \nEn cada una de ellas el alero recibirá un pase de cada uno de los pasadores (diferentes posiciones) \nEl objetivo será finalizar en canasta el máximo nº de acciones posibles \nLos pases llegan desde diferentes alturas y direcciones por lo que será necesario el desplazamiento y la orientación corporal para finalizar con rapidez y eficacia", "Hard", 18, "10.gif", "Low", "material1, material2", "Finalizaciones exteriores", "Calentamiento", "Grupos" },
                    { 11, "Basket", "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones", "Hard", 14, "11.gif", "Hard", "material1, material2", "Rueda de contraataques", "Calentamiento", "Grupos" },
                    { 12, "Basket", "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo \nEl primer grupo realiza a velocidad (80%)la distancia de 6,25 a 6,25 m y despúes andando(recuperación) \nLos grupos van saliendo a modo de relevos (llega uno sale el otro)", "Hard", 7, "12.gif", "Hard", "material1, material2", "Farlek a todo el campo", "Calentamiento", "Grupos" },
                    { 13, "Basket", "En movimiento alrededor del campo se combinan: Trote, movilidad articular, estiramientos,cambios de dirección y de ritmo", "Low", 7, "13.gif", "Low", "material1", "Calentamiento general dinámico", "Calentamiento", "Individual" },
                    { 14, "Basket", "Dos atacantes contra 2 defensores con 2 apoyos exteriores situados fuera de la línea de 6,25 \nSi los atacantes consiguen canasta los defensores siguen en su función y éstos cambian su función con los jugadores exteriores \nSi no consiguen canasta se quedan a defender frente al equipo exterior", "Low", 14, "14.gif", "Medium", "material1, material2", "2 contra 2 con apoyos exteriores", "Fisico", "Grupos" },
                    { 15, "Basket", "Saque lateral en el que el base parte del poste bajo para salir a recibir al exterior \nEl base se desplaza hacia el lado contrario para realizar un pick and roll con el poste alto (4) \nEl (3) realiza un bloqueo ciego al defensor del (5) y corta la zona hacia el poste alto \nEl (4) tras realizar el pick and roll realiza un bloqueo vertical al defensor del (3) \nSe buscan dos posibles finalizaciones: a)Pase y finalización exterior por parte del (3). b)Pase interior y finalización 1x1 del (5)", "Hard", 18, "15.gif", "Hard", "material1, material2, material3", "Bloqueos verticales y ciegos", "Calentamiento", "Grupos" },
                    { 16, "Basket", "Desplazarse en grupo coordinando el ritmo de movimiento \nUno detrás del ótro agarra la pierna del compañero \nApoyarse uno con el ótro por la espalda", "Medium", 18, "16.gif", "Medium", "material1", "Fila de cojos", "Fisico", "Grupos" },
                    { 17, "Basket", "Intentar salir por los huecos que dejen los compañeros entre piernas, brazos o por encima", "Hard", 14, "17.gif", "Hard", "material1, material2", "Sal del corro", "Fisico", "Grupos" },
                    { 18, "Basket", "1)Abdominal superior piernas extendidas \n2)Abdominal inferior elevando alternativamente las piernas extendidas \n3)Oblicuos mediante inclinaciones laterales de tronco \n4)Lumbares con elevación de tronco con el tren inferior apoyado \n5)Abdominal inferior mediante flexión- extensión de piernas simultáneamente a ras de suelo \n6)Abdominal superior con elevación de piernas a 90 º \nRealizar 2 Vueltas completas al circuitoColocarse cogidos de la mano y dentro un jugador", "Hard", 14, "18.gif", "Hard", "material1, material2", "Circuito Abdominales 2", "Estiramiento", "Individual" },
                    { 19, "Basket", "1)Lanzar el balón de un brazo a otro por encima de la cabeza \n2)Salto a la comba con pies juntos \n3)Rotación de brazos(uno hacia delante, el otro hacia atrás) \n4ª)Dominios de balón por el aire \n5)Realizar el pino(con o sin apoyo) \n6)Desplazamiento de espaldas en zig-zag \nRealizar 2 Vueltas completas al circuito", "Low", 7, "19.gif", "Medium", "material1, material2, material3, material4, material5", "Circuito de coordinación", "Estiramiento", "Individual" },
                    { 20, "Basket", "1)Elevación de pierna al pecho del compañero y buscar con ambas manos puntera y pie apoyado \n2)Apertura lateral de ambas piernas y flexión del tronco hacia delante con ayuda \n3)Ambos compañeros con apertura lateral de ambas piernas y agarrados por las manos tratando de juntar las pelvis \n4)Tumbado boca abajo elevación de una pierna hacia atrás \n5)Tumbado boca abajo elevación de tronco \n6)Tumbado boca arriba llevar ambas piernas hacia el tronco", "Medium", 7, "fexi2.gif", "Medium", "material1, material2, material3, material4", "Circuito de flexibilidad por parejas", "Estiramiento", "Parejas" },
                    { 21, "Basket", "Se enfrentan 2 equipos de 3 jugadores cada uno \nConsiste en mantener la posesión del balón con la ayuda de los dos jugadores que se encuentran fuera del espacio de juego (pivotes) \nEl resto jugarán cada uno en su zona delimitada, que no podrán abandonar", "Medium", 14, "20.gif", "Hard", "material1, material2, material3, material4", "Defensa individual cada uno en su zona", "Fisico", "Grupos" },
                    { 22, "Basket", "Partiendo en caja; (3) y (4) postes bajos, (5) y (1) postes altos El a…", "Low", 14, "21.gif", "Hard", "material1, material2, material3", "Box horizontal y tiro exterior", "Calentamiento", "Grupos" },
                    { 23, "Basket", "Elevarse y descender sin ayuda de las manos \nApoyarse uno con el ótro por la espalda", "Low", 14, "22.gif", "Low", "material1", "La silla adaptable", "Fisico", "Parejas" },
                    { 24, "Basket", "1)Apertura lateral de ambas piernas e inclinación del tronco hacia delante buscando las punteras \n2)Fondos de brazos(realizando la lagartija) \n3)Extensión de cuadriceps en equilibrio sobre 1 pierna \n4)De cuclillas estiramiento lateral de una piern \n5)De rodillas inclinación del tronco hacia delante-atrás \n6)Posición del salto de valla buscando las punteras \nRealizar 2 vueltas completas al circuito", "Low", 7, "fexi.gif", "Low", "material1, material2, material3, material4", "Circuito de Flexibilidad", "Estiramiento", "Individual" },
                    { 25, "Basket", "Consiste en evitar tocar el pivote \nLos jugadores se posicionan en círculo con un pivote en la mitad \nDan vueltas en una dirección y a la señal intentarán traccionar a todos sus compañeros hacia atrás para que uno de éllos toque con cualquier parte del cuerpo el pivote \nEl jugador que lo haya tocado quedará eliminado", "Hard", 18, "23.gif", "Medium", "material1, material2", "¿Quien tocará el pivote?", "Fisico", "Grupos" },
                    { 26, "Basket", "Los jugadores se colocan formando un círculo \nUn jugador se desplaza a trote por el exterior \nA la voz del entrenador el jugador que se encuentra a su altura debe intentar cogerle antes de que el jugador exterior pueda ocupar su sitio tras dar una vuelta \ncompleta al círculo", "Low", 7, "24.gif", "Low", "material1", "Te robo la casa", "Fisico", "Grupos" },
                    { 27, "Basket", "Se colocan en las esquinas del medio del campo \nSe empieza en una línea de fondo \nLos defensores deberán esprintar para llegar a tiempo", "Medium", 7, "25.gif", "Medium", "material1, material2", "Defensa 2x2", "Fisico", "Grupos" },
                    { 28, "Basket", "Tres jugadores en el centro del campo empezarán atacando \nDos jugadores se colocarán en cada zona como defensores y otros 2 en cada mitad de campo \nAtacan 3 para 2 y van todos al rebote \nEl que coja el rebote pasa rápidamente a uno de los que esperan en las bandas \nEl que cogió el rebote y los 2 jugadores que esperaban se organizan para atacar al otro aro \nLos 4 que se quedan se reparten:2 defienden y 2 esperan en las bandas", "Medium", 14, "vuel.gif", "Hard", "material1, material2, material3", "Contrataque de 11", "Calentamiento", "Grupos" },
                    { 29, "Basket", " Consiste en llegar lo antes posible a uno de los 4 pivotes \nLos pivotes estarán numerados \nA la señal del entrenador los jugadores se dirigirán al pivote que él haya nombrado \nEl último en llegar quedará elimindo", "Medium", 14, "9.gif", "Hard", "material1, material2", "Número y corre", "Fisico", "Grupos" },
                    { 30, "Basket", "Se juegan situaciones 1 contra 1 en medio campo con el objetivo de llegar a un nº determinado de puntos (7)", "Hard", 18, "24.gif", "Hard", "material1, material2", "Puntuación global 1x1", "Fisico", "Grupos" },
                    { 32, "Futbol", "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies entre pica y pica con aceleración \n3)Carrera en sprint mediante zig- zag \n4)Ampliar la zancada progresivamente 1 apoyo entre pica y pica \n5)Saltos a pies juntos por encima de las vallas y aceleración \n6)Amplitud introduciendo una pierna en cada aro", "Medium", 14, "Pfi-0050.gif", "Hard", "material1, material2, material3, material4", "Circuito de Velocidad", "Fisico", "Grupos" },
                    { 33, "Futbol", "Se divide a la plantilla en 2 equipos que juegan por mantener la posesión del balón \nEn la zona (recuadro) marcado únicamente podrá entrar un jugador por equipo \nSe conseguirá un tanto a favor cuando un equipo sea capaz de realizar una combinación de pase y devolución con uno de sus jugadores que previamente haya entrado en \ndicha zona \nNo se puede permanecer en la zona de marca", "Hard", 18, "Glo-0014.gif", "Hard", "material1, material2, material3", "Combinación interior", "Calentamiento", "Grupos" },
                    { 34, "Futbol", "Se formará un círculo con todos los jugadores excepto uno que se colocará en el exterior del círculo \nLos jugadores que están situados en círculo se pasan un balón mientrás que el jugador exterior debe de correr hasta interceptarlo \nAl jugador que se le haya interceptado el balón se colocará en el exterior \nUna distancia entre jugador y jugador de 3 metros", "Medium", 14, "Pfi-0031.gif", "Medium", "material1, material2", "Balón viajero", "Fisico", "Grupos" },
                    { 35, "Futbol", "1)Elevación de brazos por encima de la cabeza con resistencia(hacia abajo) \n2)Fondos de brazos con resistencia \n3)Avanzar haciendo la carretilla \n4)Empujar uno contra otro con brazos extendidos \n5)Pulso en el suelo con apoyo de 1 brazo \n6)Juntar los brazos al cuerpo con resistencia(hacia arriba) \nRealizar 2 vueltas completas al circuito:1ª)30” de acción 30” de recuperación", "Hard", 14, "Pfi-0037.gif", "Hard", "material1", "Circuito de brazos por parejas", "Estiramiento", "Parejas" },
                    { 36, "Futbol", "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies entre pica y pica con aceleración \n3)Carrera en sprint mediante zig- zag \n4)Ampliar la zancada progresivamente 1 apoyo entre pica y pica \n5)Saltos a pies juntos por encima de las vallas y aceleración \n6)Amplitud introduciendo una pierna en cada aro", "Medium", 14, "Pfi-0050.gif", "Medium", "material1, material2, material3", "Circuito de Velocidad", "Fisico", "Individual" },
                    { 38, "Futbol", "El circuito se realizará por repeticiones y se darán 3 vueltas al circuito \n1ª) 20 repeticiones por posta 2ª) 15 repeticiones por posta 3ª) 10 repeticiones por posta \nSe recuperará aproximadamente 30 entre posta y posta \nPostas: 1-Abd.dorsal 2-Lumbares con elevación de piernas 3-Abd.inferior con elevación de piernas 4-Abd. superior piernas extendidas 5-Lumbares con elevación de \ntronco 6-Abd.superior con piernas semiflexionadas", "Low", 7, "Pfi-0029.gif", "Low", "material1", "Circuito de Abdmominales", "Fisico", "Individual" },
                    { 39, "Futbol", "En una zona delimitada por los pivotes se colocarán 5 jugadores,un balón por jugador y 5 pivotes", "Low", 7, "Pfi-0038.gif", "Low", "material1", "Juego de calentamiento", "Calentamiento", "Grupos" },
                    { 40, "Futbol", "1)Flexión y extensión de piernas con oposición \n2)Intentar bajar al suelo frente a la oposición la pierna extendida \n3)Avanzar cargando a burros con el compañero \n4)Saltos por encima del compañero agachado \n5)Flexión-extensión simultánea de las piernas(con oposición),con la espalda apoyada en el suelo \n6)Resistencia a la carrera con agarre por la cintura", "Medium", 14, "Pfi-0047.gif", "Medium", "material1", "Circuito de piernas por parejas", "Estiramiento", "Parejas" },
                    { 41, "Futbol", "Se divide el terreno de juego en 3 zonas \ndentro de cada zona se sitúan 2 jugadores ofensivos y 1 jugador defensivo \nEl objetivo será realizar cambios de orientación continuos obligando a que el balón pase por ambas bandas \nCada vez que se consiga un cambio de orientación completo se conseguirá un punto \nLos defensores deben presionar en su zona a los dos jugadores atacantes", "Hard", 14, "Esp(centrocamp)-0001", "Hard", "material1, material2", "Cambios de orientación", "Calentamiento", "Grupos" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Deporte", "Descripcion", "Dificultad", "Edad", "Imagen", "Intensidad", "Material", "Nombre", "Objetivo", "Personas" },
                values: new object[,]
                {
                    { 42, "Futbol", "Dividir a la plantilla en tres equipos \n2 equipos juegan dentro del campo y el otro equipo se sitúa como apoyo exterior \nLos dos equipos interiores luchan por mantener la posesión del balón para lo que se pueden apoyar en los jugadores que se encuentran en el exterior \nCada 8 o 10 min cambiar el equipo exterior por uno de los interiores", "Low", 7, "Glo-0012.gif", "Low", "material1, material2, material3", "Posesión 3 colores", "Calentamiento", "Grupos" },
                    { 43, "Futbol", "1)Carrera en sprint hasta la 1ªseñal vuelta recuperando, sprint hasta …", "Medium", 14, "Pfi-0035.gif", "Medium", "material1, material2", "Circuito Fisico- Técnico", "Fisico", "Parejas" },
                    { 44, "Futbol", "Dividir a la plantilla en 2 equipos \nCada equipo defiende-ataca 3 porterías pequeñas situadas a lo largo de la línea de fondo \nEl gol se conseguirá introduciendo el balón en cualquiera de las 3 porterías", "Medium", 7, "Glo-0001.gif", "Medium", "material1, material2, material3, material4", "Partido 6 porterías", "Calentamiento", "Grupos" },
                    { 45, "Futbol", "Dividir a la plantilla en equipos de 4 jugadores \nPartido en espacio reducido entre 2 equipos \nCombinar apoyos, paredes, regates,...para meter gol \nEl juego se desarrollará con máxima intensidad", "Low", 7, "Glo-0002.gif", "Low", "material1, material2, material3, material4", "Juego corto 4 contra 4", "Calentamiento", "Grupos" },
                    { 46, "Futbol", "Dividir la plantilla en 2 equipos \nJugar 7x7 más 2 porteros \nEstablecer objetivos tácticos según necesidades;pressing, repliegue, cambios de orientación..", "Medium", 14, "Glo-0010.gif", "Medium", "material1, material2, material3, material4", "Partido medio campo 7x7", "Calentamiento", "Grupos" },
                    { 47, "Futbol", "Dividir a la plantila en 2 equipos \nCada equipo mantendrá un jugador en su zona defensiva que no podrá salir de ésta \nPara marcar gol tendrán 2 posibilidades:Tirar sobre la portería defendida por el portero ó conducir a través de los conos", "Hard", 18, "Glo-0011.gif", "Hard", "material1, material2, material3, material4", "Juego en 3 zonas", "Calentamiento", "Grupos" },
                    { 48, "Futbol", "Se divide a la plantilla en dos equipos \nDentro del campo juegan 4 x 4 ó 5 x 5 (+ 2 porteros), en los fondos y en los laterales de las porterías se colocan jugadores del equipo que ataca \nSe juega en todo momento con la cabeza y únicamente puede cogerse el balón con la mano despues de un bote \nCada 3 o 4 minutos se cambian los jugadores que realizan los apoyos exteriores", "Medium", 14, "Glo-0005.gif", "Medium", "material1, material2, material3, material4", "Juego corto con la cabeza", "Calentamiento", "Grupos" },
                    { 49, "Futbol", "Elevarse y descender sin ayuda de las manos \nApoyarse uno con el ótro por la espalda", "Low", 7, "Pfi-0002.gif", "Low", "material1, material2, material3, material4", "La silla adaptable", "Fisico", "Parejas" },
                    { 50, "Futbol", "Dos filas con los jugadores colocados espalda contra espalda y con los brazos entrelazados intentan empujar", "Medium", 7, "Pfi-0026.gif", "Medium", "material1", "La fila que se empuja", "Fisico", "Grupos" }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "PlanId", "Descripcion", "Planes", "Precio", "Price" },
                values: new object[,]
                {
                    { 1, "El plan Básico que permite a los usuarios visualizar diferentes ejercicios. Además, podrán seguir a otros usuarios y ver sus actividades", "Basico", 0, "Gratis" },
                    { 2, "El plan Medium ofrece a los usuarios poder ver TODOS los ejercicios que la aplicación ofrece. Se elimina la publicidad", "Medium", 4, "4€" },
                    { 3, "El plan Pro dispone de todas las ventajas del plan Medium, pero añade la funcionalidad de poder comentar y valorar los ejercicios. Además, permite crear ejercicios a los usuarios para aportar más información a la app.", "Pro", 7, "7€" }
                });

            migrationBuilder.InsertData(
                table: "Usages",
                columns: new[] { "UsageId", "Basico", "Basket", "Clientes", "Futbol", "Medium", "Month", "Pro" },
                values: new object[,]
                {
                    { 1, 30, 28, 50, 32, 15, "January", 5 },
                    { 2, 25, 28, 50, 30, 20, "February", 5 },
                    { 3, 30, 29, 55, 35, 18, "March", 7 },
                    { 4, 33, 37, 65, 40, 25, "April", 7 },
                    { 5, 40, 50, 70, 50, 20, "May", 10 },
                    { 6, 50, 63, 90, 70, 25, "June", 15 },
                    { 7, 65, 75, 105, 80, 27, "July", 23 },
                    { 8, 70, 87, 120, 92, 20, "August", 30 },
                    { 9, 50, 54, 75, 60, 15, "September", 10 },
                    { 10, 50, 40, 70, 35, 10, "October", 10 },
                    { 11, 45, 27, 65, 30, 10, "November", 10 },
                    { 12, 45, 35, 60, 32, 5, "Dicember", 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Apellidos", "Email", "Frase", "Name", "Password", "Plan" },
                values: new object[,]
                {
                    { 1, "admin", "admin@gmail.com", "admin", "Admin", "admin", "Pro" },
                    { 2, "Torres Berraquero", "andrescabezon@gmail.com", "Nunca digas nunca!! 😜", "Andrelo", "1234", "Pro" },
                    { 3, "Mearte Tiberio", "gabolon@gmail.com", "Ahi con las requetonas!!", "Gabolon", "123", "Basico" },
                    { 4, "Ezquerra Belchite", "belchite@gmail.com", "Soy muy vago!!", "Cristian", "12345", "Basico" },
                    { 5, "Gutierrez Ramon", "nikorx@gmail.com", "Tomate pero unas vacaciones", "Niko", "33", "Pro" },
                    { 6, "Blancash Sara", "blancash@gmail.com", "Enamorado de la vida!! 😜", "Cristian", "33", "Medium" },
                    { 7, "Panchez Esteban", "antonion@gmail.com", "Me gusta quejarme", "Toño", "33", "Basico" },
                    { 8, "Eres Ungenio", "1@gmail.com", "Hey there! I'm using Pro-Tactic", "Gabo", "1", "Basico" },
                    { 9, "33", "2@gmail.com", "Hey there! I'm using Pro-Tactic", "3", "2", "Pro" },
                    { 10, "Torres Berraquero", "Atorres@gmail.com", "Hey there! I'm using Pro-Tactic", "Andres", "1", "Basico" },
                    { 11, "Torres Berraquero", "Andres@gmail.com", "Hey there! I'm using Pro-Tactic", "Andresito", "1", "Pro" },
                    { 12, "prueba prueba", "prueba@gmail.com", "Hey there! I'm using Pro-Tactic", "pruebaFinal", "123", "Basico" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Usages");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
