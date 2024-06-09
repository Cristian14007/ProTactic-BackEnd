using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41,
                column: "Imagen",
                value: "Esp(centrocamp)-0001.gif");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 41,
                column: "Imagen",
                value: "Esp(centrocamp)-0001");
        }
    }
}
