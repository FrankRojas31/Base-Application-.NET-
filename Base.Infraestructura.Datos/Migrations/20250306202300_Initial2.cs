using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Base.Infraestructura.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "Tbl_Profesor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "Tbl_Alumnos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Alumnos_Tbl_Persona_IdPersona",
                table: "Tbl_Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Profesor_Tbl_Persona_IdPersona",
                table: "Tbl_Profesor");

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "Tbl_Profesor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdPersona",
                table: "Tbl_Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Alumnos_Tbl_Persona_IdPersona",
                table: "Tbl_Alumnos",
                column: "IdPersona",
                principalTable: "Tbl_Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Profesor_Tbl_Persona_IdPersona",
                table: "Tbl_Profesor",
                column: "IdPersona",
                principalTable: "Tbl_Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
