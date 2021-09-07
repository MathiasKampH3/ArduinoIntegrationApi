using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class addedChangesToDataModelsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors");

            migrationBuilder.DropForeignKey(
                name: "FK_WindowLocks_Rooms_RoomName",
                table: "WindowLocks");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "WindowLocks",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "LightSensors",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors");

            migrationBuilder.DropForeignKey(
                name: "FK_WindowLocks_Rooms_RoomName",
                table: "WindowLocks");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "WindowLocks",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "LightSensors",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddForeignKey(
                name: "FK_LightSensors_Rooms_RoomName",
                table: "LightSensors",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WindowLocks_Rooms_RoomName",
                table: "WindowLocks",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
