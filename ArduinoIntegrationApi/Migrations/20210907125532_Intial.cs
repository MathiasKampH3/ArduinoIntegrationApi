using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomName);
                });

            migrationBuilder.CreateTable(
                name: "LightSensors",
                columns: table => new
                {
                    L_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L_Value = table.Column<bool>(type: "bit", nullable: false),
                    L_Cts = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComponentType = table.Column<int>(type: "int", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightSensors", x => x.L_Id);
                    table.ForeignKey(
                        name: "FK_LightSensors_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemperatureSensors",
                columns: table => new
                {
                    T_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Value = table.Column<float>(type: "real", nullable: false),
                    T_Cts = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComponentType = table.Column<int>(type: "int", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureSensors", x => x.T_Id);
                    table.ForeignKey(
                        name: "FK_TemperatureSensors_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WindowLocks",
                columns: table => new
                {
                    W_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    W_Value = table.Column<bool>(type: "bit", nullable: false),
                    W_Cts = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComponentType = table.Column<int>(type: "int", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindowLocks", x => x.W_Id);
                    table.ForeignKey(
                        name: "FK_WindowLocks_Rooms_RoomName",
                        column: x => x.RoomName,
                        principalTable: "Rooms",
                        principalColumn: "RoomName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LightSensors_RoomName",
                table: "LightSensors",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureSensors_RoomName",
                table: "TemperatureSensors",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_WindowLocks_RoomName",
                table: "WindowLocks",
                column: "RoomName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LightSensors");

            migrationBuilder.DropTable(
                name: "TemperatureSensors");

            migrationBuilder.DropTable(
                name: "WindowLocks");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
