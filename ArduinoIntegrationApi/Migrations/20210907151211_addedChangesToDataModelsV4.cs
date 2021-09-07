using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class addedChangesToDataModelsV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors");

            migrationBuilder.DropForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors");

            migrationBuilder.DropForeignKey(
                name: "FK_WindowLocks_Rooms_RoomName",
                table: "WindowLocks");

            migrationBuilder.DropIndex(
                name: "IX_WindowLocks_RoomName",
                table: "WindowLocks");

            migrationBuilder.DropIndex(
                name: "IX_TemperatureSensors_RoomName",
                table: "TemperatureSensors");

            migrationBuilder.DropIndex(
                name: "IX_LightSensors_RoomName",
                table: "LightSensors");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "WindowLocks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "TemperatureSensors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "LightSensors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "WindowLocks",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "TemperatureSensors",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "LightSensors",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_WindowLocks_RoomName",
                table: "WindowLocks",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureSensors_RoomName",
                table: "TemperatureSensors",
                column: "RoomName");

            migrationBuilder.CreateIndex(
                name: "IX_LightSensors_RoomName",
                table: "LightSensors",
                column: "RoomName");

            migrationBuilder.AddForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WindowLocks_Rooms_RoomName",
                table: "WindowLocks",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
