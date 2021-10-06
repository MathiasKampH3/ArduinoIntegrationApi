using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class AddedAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurtainReadingCur_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FeetTemperatureReadingTs_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HumidityReadingHum_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LightReadingLs_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoundReadingSr_Id",
                table: "RoomDatas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CurtainReading",
                columns: table => new
                {
                    Cur_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cur_Value = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurtainReading", x => x.Cur_Id);
                });

            migrationBuilder.CreateTable(
                name: "HumidityReading",
                columns: table => new
                {
                    Hum_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hum_Value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumidityReading", x => x.Hum_Id);
                });

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

            migrationBuilder.CreateTable(
                name: "SoundReading",
                columns: table => new
                {
                    Sr_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sr_Value = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundReading", x => x.Sr_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_CurtainReadingCur_Id",
                table: "RoomDatas",
                column: "CurtainReadingCur_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_FeetTemperatureReadingTs_Id",
                table: "RoomDatas",
                column: "FeetTemperatureReadingTs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_HumidityReadingHum_Id",
                table: "RoomDatas",
                column: "HumidityReadingHum_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_LightReadingLs_Id",
                table: "RoomDatas",
                column: "LightReadingLs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDatas_SoundReadingSr_Id",
                table: "RoomDatas",
                column: "SoundReadingSr_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_CurtainReading_CurtainReadingCur_Id",
                table: "RoomDatas",
                column: "CurtainReadingCur_Id",
                principalTable: "CurtainReading",
                principalColumn: "Cur_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_HumidityReading_HumidityReadingHum_Id",
                table: "RoomDatas",
                column: "HumidityReadingHum_Id",
                principalTable: "HumidityReading",
                principalColumn: "Hum_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_LightReading_LightReadingLs_Id",
                table: "RoomDatas",
                column: "LightReadingLs_Id",
                principalTable: "LightReading",
                principalColumn: "Ls_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_SoundReading_SoundReadingSr_Id",
                table: "RoomDatas",
                column: "SoundReadingSr_Id",
                principalTable: "SoundReading",
                principalColumn: "Sr_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomDatas_TemperatureReading_FeetTemperatureReadingTs_Id",
                table: "RoomDatas",
                column: "FeetTemperatureReadingTs_Id",
                principalTable: "TemperatureReading",
                principalColumn: "Ts_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_CurtainReading_CurtainReadingCur_Id",
                table: "RoomDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_HumidityReading_HumidityReadingHum_Id",
                table: "RoomDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_LightReading_LightReadingLs_Id",
                table: "RoomDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_SoundReading_SoundReadingSr_Id",
                table: "RoomDatas");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomDatas_TemperatureReading_FeetTemperatureReadingTs_Id",
                table: "RoomDatas");

            migrationBuilder.DropTable(
                name: "CurtainReading");

            migrationBuilder.DropTable(
                name: "HumidityReading");

            migrationBuilder.DropTable(
                name: "LightReading");

            migrationBuilder.DropTable(
                name: "SoundReading");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_CurtainReadingCur_Id",
                table: "RoomDatas");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_FeetTemperatureReadingTs_Id",
                table: "RoomDatas");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_HumidityReadingHum_Id",
                table: "RoomDatas");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_LightReadingLs_Id",
                table: "RoomDatas");

            migrationBuilder.DropIndex(
                name: "IX_RoomDatas_SoundReadingSr_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "CurtainReadingCur_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "FeetTemperatureReadingTs_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "HumidityReadingHum_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "LightReadingLs_Id",
                table: "RoomDatas");

            migrationBuilder.DropColumn(
                name: "SoundReadingSr_Id",
                table: "RoomDatas");
        }
    }
}
