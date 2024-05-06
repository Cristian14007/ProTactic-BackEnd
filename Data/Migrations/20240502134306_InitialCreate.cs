using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Exercises",
                columns: new[] { "ExerciseId", "Deporte", "Descripcion", "Dificultad", "Edad", "Imagen", "Intensidad", "Material", "Nombre", "Objetivo", "Personas" },
                values: new object[,]
                {
                    { 1, "Basket", "En este ejercicios, vamos a necesitar 2 equipos de al menos 3-4 person…", "Low", 7, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2, material3 ,material4", "Posesion por equipos", "Calentamiento", "Grupos" },
                    { 2, "Basket", "A la voz del entrenador todos los jugadores cambiarán de pivotes 4 jug…", "Low", 7, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Low", "material1, material2", "Las 4 esquinas", "Calentamiento", "Grupos" },
                    { 3, "Basket", "Se realizan 2 rondos con dos jugadores dentro y el resto fuera pasando…", "Low", 7, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2, material3", "Rondo de pases y velocidad", "Calentamiento", "Grupos" },
                    { 4, "Basket", "Cuando el entrenador diga un número saldrá un jugador de cada equipo C…", "Low", 14, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Low", "material1, material2, material3", "Pañuelito con balón", "Calentamiento", "Grupos" },
                    { 5, "Basket", "Pase frontal entre 2 jugadores Una vez realizado el pase conducción co…", "Low", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2, material3", "Velocidad", "Calentamiento", "Grupos" },
                    { 6, "Basket", "2 equipos juegan a eliminarse Los jugadores tendrán el balón entre las…", "Low", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2, material3", "Caza por equipos", "Calentamiento", "Grupos" },
                    { 7, "Basket", "Distribución de los jugadores en 2 campos y cada campo de dejará un ba…", "Medium", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Medium", "material1, material2, material3", "Vaciar el campo", "Calentamiento", "Grupos" },
                    { 8, "Basket", "2 equipos formados por 5 jugadores cada uno juega un partido de posesi…", "Medium", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Medium", "material1, material2, material3", "Los 10 pases", "Calentamiento", "Grupos" },
                    { 9, "Basket", "Se delimitará un espacio con un pasillo central de 3 a 5 metros donde …", "Medium", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Medium", "material1, material2, material3", "La muralla", "Calentamiento", "Grupos" },
                    { 10, "Basket", "Se divide la frontal de la zona 3 areas diferentes En cada una de ella…", "Hard", 18, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Low", "material1, material2", "Finalizaciones exteriores", "Calentamiento", "Grupos" },
                    { 11, "Basket", "4 combinaciones seguidas entre 4 jugadores alternándose las posiciones…", "Hard", 14, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2", "Rueda de contraataques", "Calentamiento", "Grupos" },
                    { 12, "Basket", "Se divide al equipo en 4 grupos que se sitúan en la linea de fondo El …", "Hard", 7, "http://entrenamientosdebaloncesto.es/Ejercicios/Baloncesto_Castellano/…", "Hard", "material1, material2", "Farlek a todo el campo", "Calentamiento", "Grupos" }
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
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
