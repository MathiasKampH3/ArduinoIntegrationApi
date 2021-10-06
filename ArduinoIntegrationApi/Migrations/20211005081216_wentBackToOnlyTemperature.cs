using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class wentBackToOnlyTemperature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_LightReading_LightReadingLs_Id",
                table: "RoomDatas");

            migrationBuilder.DropTable(
                name: "LightReading");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_LightReadingLs_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "LightReadingLs_Id",
                table: "RoomDatas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LightReadingLs_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LightReading",
                columns: table => new
                {
                    Ls_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ls_Value = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightReading", x => x.Ls_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_LightReadingLs_Id",
                table: "RoomDatas",
                column: "LightReadingLs_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_LightReading_LightReadingLs_Id",
                table: "RoomDatas",
                column: "LightReadingLs_Id",
                principalTable: "LightReading",
                principalColumn: "Ls_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
