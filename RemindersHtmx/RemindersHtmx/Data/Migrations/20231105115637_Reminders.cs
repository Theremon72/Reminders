using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RemindersHtmx.Data.Migrations
{
    public partial class Reminders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SnoozeInterval = table.Column<TimeSpan>(type: "time", nullable: false),
                    ReReminderInterval = table.Column<TimeSpan>(type: "time", nullable: false),
                    DaySchedule = table.Column<long>(type: "bigint", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reminder");
        }
    }
}
