using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Update_AudienciaTable_Add_Emissora_audienciaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audiencias_Emissoras_Emissora_audienciaId",
                table: "Audiencias");

            migrationBuilder.AlterColumn<int>(
                name: "Emissora_audienciaId",
                table: "Audiencias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Audiencias_Emissoras_Emissora_audienciaId",
                table: "Audiencias",
                column: "Emissora_audienciaId",
                principalTable: "Emissoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audiencias_Emissoras_Emissora_audienciaId",
                table: "Audiencias");

            migrationBuilder.AlterColumn<int>(
                name: "Emissora_audienciaId",
                table: "Audiencias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Audiencias_Emissoras_Emissora_audienciaId",
                table: "Audiencias",
                column: "Emissora_audienciaId",
                principalTable: "Emissoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
