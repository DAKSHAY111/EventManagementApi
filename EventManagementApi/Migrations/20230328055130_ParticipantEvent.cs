using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagementApi.Migrations
{
    /// <inheritdoc />
    public partial class ParticipantEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "ParticipantEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                table: "ParticipantEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ParticipantEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "ParticipantEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ParticipantEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "ParticipantEvent");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "ParticipantEvent");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ParticipantEvent");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ParticipantEvent");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ParticipantEvent");
        }
    }
}
