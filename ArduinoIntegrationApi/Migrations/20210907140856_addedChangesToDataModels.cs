using Microsoft.EntityFrameworkCore.Migrations;

namespace ArduinoIntegrationApi.Migrations
{
    public partial class addedChangesToDataModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "TemperatureSensors",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "TemperatureSensors",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddForeignKey(
                name: "FK_TemperatureSensors_Rooms_RoomName",
                table: "TemperatureSensors",
                column: "RoomName",
                principalTable: "Rooms",
                principalColumn: "RoomName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
