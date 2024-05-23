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
                    { 1, "Basket", "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 person…", "Low", 7, "posesion.gif", "Hard", "material1, material2, material3 ,material4", "Posesion por equipos", "Calentamiento", "Grupos" },
                    { 2, "Basket", "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jug…", "Low", 7, "Pfi-0009bas.gif", "Low", "material1, material2", "Las 4 esquinas", "Calentamiento", "Grupos" },
                    { 3, "Basket", "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasando…", "Low", 7, "3.gif", "Hard", "material1, material2, material3", "Rondo de pases y velocidad", "Calentamiento", "Grupos" },
                    { 4, "Basket", "Cuando el entrenador diga un número saldrá un jugador de cada equipo C…", "Low", 14, "4.gif", "Low", "material1, material2, material3", "Pañuelito con balón", "Calentamiento", "Grupos" },
                    { 5, "Basket", "Pase frontal entre 2 jugadores Una vez realizado el pase conducción co…", "Low", 18, "5.gif", "Hard", "material1, material2, material3", "Velocidad", "Calentamiento", "Grupos" },
                    { 6, "Basket", "2 equipos juegan a eliminarse Los jugadores tendrán el balón entre las…", "Low", 18, "6.gif", "Hard", "material1, material2, material3", "Caza por equipos", "Calentamiento", "Grupos" },
                    { 7, "Basket", "Distribución de los jugadores en 2 campos y cada campo de dejará un ba…", "Medium", 18, "7.gif", "Medium", "material1, material2, material3", "Vaciar el campo", "Calentamiento", "Grupos" },
                    { 8, "Basket", "2 equipos formados por 5 jugadores cada uno juega un partido de posesi…", "Medium", 18, "8.gif", "Medium", "material1, material2, material3", "Los 10 pases", "Calentamiento", "Grupos" },
                    { 9, "Basket", "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde …", "Medium", 18, "9.gif", "Medium", "material1, material2, material3", "La muralla", "Calentamiento", "Grupos" },
                    { 10, "Basket", "Se divide la frontal de la zona 3 areas diferentes En cada una de ella…", "Hard", 18, "10.gif", "Low", "material1, material2", "Finalizaciones exteriores", "Calentamiento", "Grupos" },
                    { 11, "Basket", "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones…", "Hard", 14, "11.gif", "Hard", "material1, material2", "Rueda de contraataques", "Calentamiento", "Grupos" },
                    { 12, "Basket", "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo El …", "Hard", 7, "12.gif", "Hard", "material1, material2", "Farlek a todo el campo", "Calentamiento", "Grupos" },
                    { 13, "Basket", "En movimiento alrededor del campo se combinan: Trote, movilidad articu…", "Low", 7, "13.gif", "Low", "material1", "Calentamiento general dinámico", "Calentamiento", "Individual" },
                    { 14, "Basket", "Dos atacantes contra 2 defensores con 2 apoyos exteriores situados fue…", "Low", 14, "14.gif", "Medium", "material1, material2", "2 contra 2 con apoyos exteriores", "Fisico", "Grupos" },
                    { 15, "Basket", "Saque lateral en el que el base parte del poste bajo para salir a reci…", "Hard", 18, "15.gif", "Hard", "material1, material2, material3", "Bloqueos verticales y ciegos", "Calentamiento", "Grupos" },
                    { 16, "Basket", "Desplazarse en grupo coordinando el ritmo de movimiento Uno detrás del…", "Medium", 18, "16.gif", "Medium", "material1", "Fila de cojos", "Fisico", "Grupos" },
                    { 17, "Basket", "Intentar salir por los huecos que dejen los compañeros entre piernas, …", "Hard", 14, "17.gif", "Hard", "material1, material2", "Sal del corro", "Fisico", "Grupos" },
                    { 18, "Basket", "1)Abdominal superior piernas extendidas 2)Abdominal inferior elevando …", "Hard", 14, "18.gif", "Hard", "material1, material2", "Circuito Abdominales 2", "Estiramiento", "Individual" },
                    { 19, "Basket", "1)Lanzar el balón de un brazo a otro por encima de la cabeza 2)Salto a…", "Low", 7, "19.gif", "Medium", "material1, material2, material3, material4, material5", "Circuito de coordinación", "Estiramiento", "Individual" },
                    { 20, "Basket", "1)Elevación de pierna al pecho del compañero y buscar con ambas manos …", "Medium", 7, "fexi2.gif", "Medium", "material1, material2, material3, material4", "Circuito de flexibilidad por parejas", "Estiramiento", "Parejas" },
                    { 21, "Basket", "Se enfrentan 2 equipos de 3 jugadores cada uno Consiste en mantener la…", "Medium", 14, "20.gif", "Hard", "material1, material2, material3, material4", "Defensa individual cada uno en su zona", "Fisico", "Grupos" },
                    { 22, "Basket", "Partiendo en caja; (3) y (4) postes bajos, (5) y (1) postes altos El a…", "Low", 14, "21.gif", "Hard", "material1, material2, material3", "Box horizontal y tiro exterior", "Calentamiento", "Grupos" },
                    { 23, "Basket", "Elevarse y descender sin ayuda de las manos Apoyarse uno con el ótro p…", "Low", 14, "22.gif", "Low", "material1", "La silla adaptable", "Fisico", "Parejas" },
                    { 24, "Basket", "1)Apertura lateral de ambas piernas e inclinación del tronco hacia del…", "Low", 7, "fexi.gif", "Low", "material1, material2, material3, material4", "Circuito de Flexibilidad", "Estiramiento", "Individual" },
                    { 25, "Basket", "Consiste en evitar tocar el pivote Los jugadores se posicionan en círc…", "Hard", 18, "23.gif", "Medium", "material1, material2", "¿Quien tocará el pivote?", "Fisico", "Grupos" },
                    { 26, "Basket", "Los jugadores se colocan formando un círculo Un jugador se desplaza a …", "Low", 7, "24.gif", "Low", "material1", "Te robo la casa", "Fisico", "Grupos" },
                    { 27, "Basket", "Se colocan en las esquinas del medio del campo Se empieza en una línea…", "Medium", 7, "25.gif", "Medium", "material1, material2", "Defensa 2x2", "Fisico", "Grupos" },
                    { 28, "Basket", "Tres jugadores en el centro del campo empezarán atacando Dos jugadores…", "Medium", 14, "vuel.gif", "Hard", "material1, material2, material3", "Contrataque de 11", "Calentamiento", "Grupos" },
                    { 29, "Basket", "Consiste en llegar lo antes posible a uno de los 4 pivotes Los pivotes…", "Medium", 14, "9.gif", "Hard", "material1, material2", "Número y corre", "Fisico", "Grupos" },
                    { 30, "Basket", "Se juegan situaciones 1 contra 1 en medio campo con el bojetivo de lle…", "Hard", 18, "24.gif", "Hard", "material1, material2", "Puntuación global 1x1", "Fisico", "Grupos" },
                    { 32, "Futbol", "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies…", "Medium", 14, "Pfi-0050.gif", "Hard", "material1, material2, material3, material4", "Circuito de Velocidad", "Fisico", "Grupos" },
                    { 33, "Futbol", "Se divide a la plantilla en 2 equipos que juegan por mantener la poses…", "Hard", 18, "Glo-0014.gif", "Hard", "material1, material2, material3", "Combinación interior", "Calentamiento", "Grupos" },
                    { 34, "Futbol", "Se formará un círculo con todos los jugadores excepto uno que se coloc…", "Medium", 14, "Pfi-0031.gif", "Medium", "material1, material2", "Balón viajero", "Fisico", "Grupos" },
                    { 35, "Futbol", "1)Elevación de brazos por encima de la cabeza con resistencia(hacia ab…", "Hard", 14, "Pfi-0037.gif", "Hard", "material1", "Circuito de brazos por parejas", "Estiramiento", "Parejas" },
                    { 36, "Futbol", "1)Carrera en sprint realizando slalom 2)Frecuencia apoyo de ambos pies…", "Medium", 14, "Pfi-0050.gif", "Medium", "material1, material2, material3", "Circuito de Velocidad", "Fisico", "Individual" },
                    { 38, "Futbol", "El circuito se realizará por repeticiones y se darán 3 vueltas al circ…", "Low", 7, "Pfi-0029.gif", "Low", "material1", "Circuito de Abdmominales", "Fisico", "Individual" },
                    { 39, "Futbol", "En una zona delimitada por los pivotes se colocarán 5 jugadores,un bal…", "Low", 7, "Pfi-0038.gif", "Low", "material1", "Juego de calentamiento", "Calentamiento", "Grupos" },
                    { 40, "Futbol", "1)Flexión y extensión de piernas con oposición 2)Intentar bajar al sue…", "Medium", 14, "Pfi-0047.gif", "Medium", "material1", "Circuito de piernas por parejas", "Estiramiento", "Parejas" },
                    { 41, "Futbol", "Se divide el terreno de juego en 3 zonas dentro de cada zona se sitúan…", "Hard", 14, "Esp(centrocamp)-0001", "Hard", "material1, material2", "Cambios de orientación", "Calentamiento", "Grupos" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Deporte", "Descripcion", "Dificultad", "Edad", "Imagen", "Intensidad", "Material", "Nombre", "Objetivo", "Personas" },
                values: new object[,]
                {
                    { 42, "Futbol", "Dividir a la plantilla en tres equipos 2 equipos juegan dentro del cam…", "Low", 7, "Glo-0012.gif", "Low", "material1, material2, material3", "Posesión 3 colores", "Calentamiento", "Grupos" },
                    { 43, "Futbol", "1)Carrera en sprint hasta la 1ªseñal vuelta recuperando, sprint hasta …", "Medium", 14, "Pfi-0035.gif", "Medium", "material1, material2", "Circuito Fisico- Técnico", "Fisico", "Parejas" },
                    { 44, "Futbol", "Dividir a la plantilla en 2 equipos Cada equipo defiende-ataca 3 porte…", "Medium", 7, "Glo-0001.gif", "Medium", "material1, material2, material3, material4", "Partido 6 porterías", "Calentamiento", "Grupos" },
                    { 45, "Futbol", "Dividir a la plantilla en equipos de 4 jugadores Partido en espacio re…", "Low", 7, "Glo-0002.gif", "Low", "material1, material2, material3, material4", "Juego corto 4 contra 4", "Calentamiento", "Grupos" },
                    { 46, "Futbol", "Dividir la plantilla en 2 equipos Jugar 7x7 más 2 porteros Establecer …", "Medium", 14, "Glo-0010.gif", "Medium", "material1, material2, material3, material4", "Partido medio campo 7x7", "Calentamiento", "Grupos" },
                    { 47, "Futbol", "Dividir a la plantila en 2 equipos Cada equipo mantendrá un jugador en…", "Hard", 18, "Glo-0011.gif", "Hard", "material1, material2, material3, material4", "Juego en 3 zonas", "Calentamiento", "Grupos" },
                    { 48, "Futbol", "Se divide a la plantilla en dos equipos Dentro del campo juegan 4 x 4 …", "Medium", 14, "Glo-0005.gif", "Medium", "material1, material2, material3, material4", "Juego corto con la cabeza", "Calentamiento", "Grupos" },
                    { 49, "Futbol", "Elevarse y descender sin ayuda de las manos Apoyarse uno con el otro p…", "Low", 7, "Pfi-0002.gif", "Low", "material1, material2, material3, material4", "La silla adaptable", "Fisico", "Parejas" },
                    { 50, "Futbol", "Dos filas con los jugadores colocados espalda contra espalda y con los…", "Medium", 7, "Pfi-0026.gif", "Medium", "material1", "La fila que se empuja", "Fisico", "Grupos" }
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
                name: "Users");
        }
    }
}
