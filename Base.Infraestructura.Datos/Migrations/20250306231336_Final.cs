using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Base.Infraestructura.Data.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Alumnos_Tbl_Persona_IdPersona",
                table: "Tbl_Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Profesor_Tbl_Persona_IdPersona",
                table: "Tbl_Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Profesor_IdPersona",
                table: "Tbl_Profesor");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Alumnos_IdPersona",
                table: "Tbl_Alumnos");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Tbl_Profesor");

            migrationBuilder.DropColumn(
                name: "IdPersona",
                table: "Tbl_Alumnos");

            migrationBuilder.AddColumn<string>(
                name: "Apellido_Materno",
                table: "Tbl_Profesor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido_Paterno",
                table: "Tbl_Profesor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Tbl_Profesor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido_Materno",
                table: "Tbl_Alumnos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido_Paterno",
                table: "Tbl_Alumnos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombres",
                table: "Tbl_Alumnos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido_Materno",
                table: "Tbl_Profesor");

            migrationBuilder.DropColumn(
                name: "Apellido_Paterno",
                table: "Tbl_Profesor");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Tbl_Profesor");

            migrationBuilder.DropColumn(
                name: "Apellido_Materno",
                table: "Tbl_Alumnos");

            migrationBuilder.DropColumn(
                name: "Apellido_Paterno",
                table: "Tbl_Alumnos");

            migrationBuilder.DropColumn(
                name: "Nombres",
                table: "Tbl_Alumnos");

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Tbl_Profesor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPersona",
                table: "Tbl_Alumnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Profesor_IdPersona",
                table: "Tbl_Profesor",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Alumnos_IdPersona",
                table: "Tbl_Alumnos",
                column: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Alumnos_Tbl_Persona_IdPersona",
                table: "Tbl_Alumnos",
                column: "IdPersona",
                principalTable: "Tbl_Persona",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Profesor_Tbl_Persona_IdPersona",
                table: "Tbl_Profesor",
                column: "IdPersona",
                principalTable: "Tbl_Persona",
                principalColumn: "Id");
        }
    }
}
