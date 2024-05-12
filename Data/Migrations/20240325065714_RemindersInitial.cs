using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reminders.Migrations
{
    /// <inheritdoc />
    public partial class RemindersInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reminder",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Important = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationTrigger",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReminderId = table.Column<long>(type: "bigint", nullable: false),
                    Latitude = table.Column<float>(type: "real", nullable: false),
                    Longitude = table.Column<float>(type: "real", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    Delay = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationTrigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationTrigger_Reminder_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeTrigger",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReminderId = table.Column<long>(type: "bigint", nullable: false),
                    CreationType = table.Column<int>(type: "int", nullable: false),
                    TimeToTrigger = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaySchedule = table.Column<long>(type: "bigint", nullable: false),
                    SnoozeInterval = table.Column<TimeSpan>(type: "time", nullable: false),
                    SnoozeIntervalMax = table.Column<TimeSpan>(type: "time", nullable: false),
                    DismissInterval = table.Column<TimeSpan>(type: "time", nullable: false),
                    DismissIntervalMax = table.Column<TimeSpan>(type: "time", nullable: false),
                    FollowUpInterval = table.Column<TimeSpan>(type: "time", nullable: false),
                    FollowUpIntervalMax = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTrigger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeTrigger_Reminder_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocationTrigger_ReminderId",
                table: "LocationTrigger",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTrigger_ReminderId",
                table: "TimeTrigger",
                column: "ReminderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationTrigger");

            migrationBuilder.DropTable(
                name: "TimeTrigger");

            migrationBuilder.DropTable(
                name: "Reminder");
        }
    }
}
