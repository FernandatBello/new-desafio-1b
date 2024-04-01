using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace new_desafio_1b.Migrations
{
    /// <inheritdoc />
    public partial class CamposFormulario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campos",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Disponibilidade = table.Column<int>(type: "int", nullable: false),
                    AnosDeExperiencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campos", x => x.Nome);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campos");
        }
    }
}
