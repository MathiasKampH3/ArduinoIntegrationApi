using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "TemperatureReading",
                columns: table => new
                {
                    Ts_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ts_Value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureReading", x => x.Ts_Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomDatas",
                columns: table => new
                {
                    Rd_RoomName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rd_Cts = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LightReadingLs_Id = table.Column<int>(type: "int", nullable: true),
                    HeadTemperatureReadingTs_Id = table.Column<int>(type: "int", nullable: true),
                    FeetTemperatureReadingTs_Id = table.Column<int>(type: "int", nullable: true),
                    HumidityReadingHum_Id = table.Column<int>(type: "int", nullable: true),
                    CurtainReadingCur_Id = table.Column<int>(type: "int", nullable: true),
                    SoundReadingSr_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDatas", x => new { x.Rd_RoomName, x.Rd_Cts });
                    table.ForeignKey(
                        name: "FK_RoomDatas_CurtainReading_CurtainReadingCur_Id",
                        column: x => x.CurtainReadingCur_Id,
                        principalTable: "CurtainReading",
                        principalColumn: "Cur_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDatas_HumidityReading_HumidityReadingHum_Id",
                        column: x => x.HumidityReadingHum_Id,
                        principalTable: "HumidityReading",
                        principalColumn: "Hum_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDatas_LightReading_LightReadingLs_Id",
                        column: x => x.LightReadingLs_Id,
                        principalTable: "LightReading",
                        principalColumn: "Ls_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDatas_SoundReading_SoundReadingSr_Id",
                        column: x => x.SoundReadingSr_Id,
                        principalTable: "SoundReading",
                        principalColumn: "Sr_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDatas_TemperatureReading_FeetTemperatureReadingTs_Id",
                        column: x => x.FeetTemperatureReadingTs_Id,
                        principalTable: "TemperatureReading",
                        principalColumn: "Ts_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDatas_TemperatureReading_HeadTemperatureReadingTs_Id",
                        column: x => x.HeadTemperatureReadingTs_Id,
                        principalTable: "TemperatureReading",
                        principalColumn: "Ts_Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_RoomDatas_HeadTemperatureReadingTs_Id",
                table: "RoomDatas",
                column: "HeadTemperatureReadingTs_Id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomDatas");

            migrationBuilder.DropTable(
                name: "CurtainReading");

            migrationBuilder.DropTable(
                name: "HumidityReading");

            migrationBuilder.DropTable(
                name: "LightReading");

            migrationBuilder.DropTable(
                name: "SoundReading");

            migrationBuilder.DropTable(
                name: "TemperatureReading");
        }
    }
}
