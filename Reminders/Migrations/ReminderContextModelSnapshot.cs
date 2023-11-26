﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reminders.Database;

#nullable disable

namespace Reminders.Migrations
{
    [DbContext(typeof(ReminderContext))]
    partial class ReminderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Reminders.Reminders.Models.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<uint>("DaySchedule")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("ReReminderInterval")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("SnoozeInterval")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reminders");
                });
#pragma warning restore 612, 618
        }
    }
}
