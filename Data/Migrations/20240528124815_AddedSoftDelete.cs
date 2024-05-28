using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reminders.Migrations
{
    /// <inheritdoc />
    public partial class AddedSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "TimeToTrigger",
                table: "TimeTrigger",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DaySchedule",
                table: "TimeTrigger",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "TimeTrigger",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TimeTrigger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTemporary",
                table: "TimeTrigger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateTime",
                table: "reminderAudits",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "reminderAudits",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "reminderAudits",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "TriggerId",
                table: "reminderAudits",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "Reminder",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DeletedAt",
                table: "LocationTrigger",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LocationTrigger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsTemporary",
                table: "LocationTrigger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_TimeTrigger_IsDeleted",
                table: "TimeTrigger",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_reminderAudits_IsDeleted",
                table: "reminderAudits",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_IsDeleted",
                table: "Reminder",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_LocationTrigger_IsDeleted",
                table: "LocationTrigger",
                column: "IsDeleted");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TimeTrigger_IsDeleted",
                table: "TimeTrigger");

            migrationBuilder.DropIndex(
                name: "IX_reminderAudits_IsDeleted",
                table: "reminderAudits");

            migrationBuilder.DropIndex(
                name: "IX_Reminder_IsDeleted",
                table: "Reminder");

            migrationBuilder.DropIndex(
                name: "IX_LocationTrigger_IsDeleted",
                table: "LocationTrigger");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "TimeTrigger");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TimeTrigger");

            migrationBuilder.DropColumn(
                name: "IsTemporary",
                table: "TimeTrigger");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "reminderAudits");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "reminderAudits");

            migrationBuilder.DropColumn(
                name: "TriggerId",
                table: "reminderAudits");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Reminder");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "LocationTrigger");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LocationTrigger");

            migrationBuilder.DropColumn(
                name: "IsTemporary",
                table: "LocationTrigger");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeToTrigger",
                table: "TimeTrigger",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<long>(
                name: "DaySchedule",
                table: "TimeTrigger",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "reminderAudits",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");
        }
    }
}
