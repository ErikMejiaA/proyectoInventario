using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class PaisEstadoRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Regiones",
                keyColumn: "nombreRegion",
                keyValue: null,
                column: "nombreRegion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "nombreRegion",
                table: "Regiones",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codRegion",
                table: "Regiones",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codEstado",
                table: "Regiones",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Paises",
                keyColumn: "nombrePais",
                keyValue: null,
                column: "nombrePais",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "nombrePais",
                table: "Paises",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codPais",
                table: "Paises",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Estados",
                keyColumn: "nombreEstado",
                keyValue: null,
                column: "nombreEstado",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "nombreEstado",
                table: "Estados",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codEstado",
                table: "Estados",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codPais",
                table: "Estados",
                type: "varchar(3)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_codEstado",
                table: "Regiones",
                column: "codEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Regiones_nombreRegion",
                table: "Regiones",
                column: "nombreRegion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paises_nombrePais",
                table: "Paises",
                column: "nombrePais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Estados_codPais",
                table: "Estados",
                column: "codPais");

            migrationBuilder.CreateIndex(
                name: "IX_Estados_nombreEstado",
                table: "Estados",
                column: "nombreEstado",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_Paises_codPais",
                table: "Estados",
                column: "codPais",
                principalTable: "Paises",
                principalColumn: "codPais",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiones_Estados_codEstado",
                table: "Regiones",
                column: "codEstado",
                principalTable: "Estados",
                principalColumn: "codEstado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Paises_codPais",
                table: "Estados");

            migrationBuilder.DropForeignKey(
                name: "FK_Regiones_Estados_codEstado",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Regiones_codEstado",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Regiones_nombreRegion",
                table: "Regiones");

            migrationBuilder.DropIndex(
                name: "IX_Paises_nombrePais",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IX_Estados_codPais",
                table: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Estados_nombreEstado",
                table: "Estados");

            migrationBuilder.DropColumn(
                name: "codEstado",
                table: "Regiones");

            migrationBuilder.DropColumn(
                name: "codPais",
                table: "Estados");

            migrationBuilder.AlterColumn<string>(
                name: "nombreRegion",
                table: "Regiones",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codRegion",
                table: "Regiones",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nombrePais",
                table: "Paises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codPais",
                table: "Paises",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "nombreEstado",
                table: "Estados",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "codEstado",
                table: "Estados",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
