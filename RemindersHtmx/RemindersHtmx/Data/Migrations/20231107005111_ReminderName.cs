using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemindersHtmx.Data.Migrations
{
    public partial class ReminderName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Reminder",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Reminder");
        }
    }
}
