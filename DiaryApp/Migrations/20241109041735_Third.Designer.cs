﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241109041735_Third")]
    partial class Third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Content for Id: 1",
                            Created = new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Content for Id: 2",
                            Created = new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Content for Id: 3",
                            Created = new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Content for Id: 4",
                            Created = new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Content for Id: 5",
                            Created = new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 5"
                        },
                        new
                        {
                            Id = 6,
                            Content = "Content for Id: 6",
                            Created = new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 6"
                        },
                        new
                        {
                            Id = 7,
                            Content = "Content for Id: 7",
                            Created = new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 7"
                        },
                        new
                        {
                            Id = 8,
                            Content = "Content for Id: 8",
                            Created = new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 8"
                        },
                        new
                        {
                            Id = 9,
                            Content = "Content for Id: 9",
                            Created = new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 9"
                        },
                        new
                        {
                            Id = 10,
                            Content = "Content for Id: 10",
                            Created = new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 10"
                        },
                        new
                        {
                            Id = 11,
                            Content = "Content for Id: 11",
                            Created = new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 11"
                        },
                        new
                        {
                            Id = 12,
                            Content = "Content for Id: 12",
                            Created = new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 12"
                        },
                        new
                        {
                            Id = 13,
                            Content = "Content for Id: 13",
                            Created = new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 13"
                        },
                        new
                        {
                            Id = 14,
                            Content = "Content for Id: 14",
                            Created = new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 14"
                        },
                        new
                        {
                            Id = 15,
                            Content = "Content for Id: 15",
                            Created = new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 15"
                        },
                        new
                        {
                            Id = 16,
                            Content = "Content for Id: 16",
                            Created = new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 16"
                        },
                        new
                        {
                            Id = 17,
                            Content = "Content for Id: 17",
                            Created = new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 17"
                        },
                        new
                        {
                            Id = 18,
                            Content = "Content for Id: 18",
                            Created = new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 18"
                        },
                        new
                        {
                            Id = 19,
                            Content = "Content for Id: 19",
                            Created = new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 19"
                        },
                        new
                        {
                            Id = 20,
                            Content = "Content for Id: 20",
                            Created = new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 20"
                        },
                        new
                        {
                            Id = 21,
                            Content = "Content for Id: 21",
                            Created = new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 21"
                        },
                        new
                        {
                            Id = 22,
                            Content = "Content for Id: 22",
                            Created = new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 22"
                        },
                        new
                        {
                            Id = 23,
                            Content = "Content for Id: 23",
                            Created = new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 23"
                        },
                        new
                        {
                            Id = 24,
                            Content = "Content for Id: 24",
                            Created = new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 24"
                        },
                        new
                        {
                            Id = 25,
                            Content = "Content for Id: 25",
                            Created = new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 25"
                        },
                        new
                        {
                            Id = 26,
                            Content = "Content for Id: 26",
                            Created = new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 26"
                        },
                        new
                        {
                            Id = 27,
                            Content = "Content for Id: 27",
                            Created = new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 27"
                        },
                        new
                        {
                            Id = 28,
                            Content = "Content for Id: 28",
                            Created = new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 28"
                        },
                        new
                        {
                            Id = 29,
                            Content = "Content for Id: 29",
                            Created = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 29"
                        },
                        new
                        {
                            Id = 30,
                            Content = "Content for Id: 30",
                            Created = new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 30"
                        },
                        new
                        {
                            Id = 31,
                            Content = "Content for Id: 31",
                            Created = new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 31"
                        },
                        new
                        {
                            Id = 32,
                            Content = "Content for Id: 32",
                            Created = new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 32"
                        },
                        new
                        {
                            Id = 33,
                            Content = "Content for Id: 33",
                            Created = new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 33"
                        },
                        new
                        {
                            Id = 34,
                            Content = "Content for Id: 34",
                            Created = new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 34"
                        },
                        new
                        {
                            Id = 35,
                            Content = "Content for Id: 35",
                            Created = new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 35"
                        },
                        new
                        {
                            Id = 36,
                            Content = "Content for Id: 36",
                            Created = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 36"
                        },
                        new
                        {
                            Id = 37,
                            Content = "Content for Id: 37",
                            Created = new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 37"
                        },
                        new
                        {
                            Id = 38,
                            Content = "Content for Id: 38",
                            Created = new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 38"
                        },
                        new
                        {
                            Id = 39,
                            Content = "Content for Id: 39",
                            Created = new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 39"
                        },
                        new
                        {
                            Id = 40,
                            Content = "Content for Id: 40",
                            Created = new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 40"
                        },
                        new
                        {
                            Id = 41,
                            Content = "Content for Id: 41",
                            Created = new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 41"
                        },
                        new
                        {
                            Id = 42,
                            Content = "Content for Id: 42",
                            Created = new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 42"
                        },
                        new
                        {
                            Id = 43,
                            Content = "Content for Id: 43",
                            Created = new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 43"
                        },
                        new
                        {
                            Id = 44,
                            Content = "Content for Id: 44",
                            Created = new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 44"
                        },
                        new
                        {
                            Id = 45,
                            Content = "Content for Id: 45",
                            Created = new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 45"
                        },
                        new
                        {
                            Id = 46,
                            Content = "Content for Id: 46",
                            Created = new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 46"
                        },
                        new
                        {
                            Id = 47,
                            Content = "Content for Id: 47",
                            Created = new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 47"
                        },
                        new
                        {
                            Id = 48,
                            Content = "Content for Id: 48",
                            Created = new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 48"
                        },
                        new
                        {
                            Id = 49,
                            Content = "Content for Id: 49",
                            Created = new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 49"
                        },
                        new
                        {
                            Id = 50,
                            Content = "Content for Id: 50",
                            Created = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 50"
                        },
                        new
                        {
                            Id = 51,
                            Content = "Content for Id: 51",
                            Created = new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 51"
                        },
                        new
                        {
                            Id = 52,
                            Content = "Content for Id: 52",
                            Created = new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 52"
                        },
                        new
                        {
                            Id = 53,
                            Content = "Content for Id: 53",
                            Created = new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 53"
                        },
                        new
                        {
                            Id = 54,
                            Content = "Content for Id: 54",
                            Created = new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 54"
                        },
                        new
                        {
                            Id = 55,
                            Content = "Content for Id: 55",
                            Created = new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 55"
                        },
                        new
                        {
                            Id = 56,
                            Content = "Content for Id: 56",
                            Created = new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 56"
                        },
                        new
                        {
                            Id = 57,
                            Content = "Content for Id: 57",
                            Created = new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 57"
                        },
                        new
                        {
                            Id = 58,
                            Content = "Content for Id: 58",
                            Created = new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 58"
                        },
                        new
                        {
                            Id = 59,
                            Content = "Content for Id: 59",
                            Created = new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 59"
                        },
                        new
                        {
                            Id = 60,
                            Content = "Content for Id: 60",
                            Created = new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 60"
                        },
                        new
                        {
                            Id = 61,
                            Content = "Content for Id: 61",
                            Created = new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 61"
                        },
                        new
                        {
                            Id = 62,
                            Content = "Content for Id: 62",
                            Created = new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 62"
                        },
                        new
                        {
                            Id = 63,
                            Content = "Content for Id: 63",
                            Created = new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 63"
                        },
                        new
                        {
                            Id = 64,
                            Content = "Content for Id: 64",
                            Created = new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 64"
                        },
                        new
                        {
                            Id = 65,
                            Content = "Content for Id: 65",
                            Created = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 65"
                        },
                        new
                        {
                            Id = 66,
                            Content = "Content for Id: 66",
                            Created = new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 66"
                        },
                        new
                        {
                            Id = 67,
                            Content = "Content for Id: 67",
                            Created = new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 67"
                        },
                        new
                        {
                            Id = 68,
                            Content = "Content for Id: 68",
                            Created = new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 68"
                        },
                        new
                        {
                            Id = 69,
                            Content = "Content for Id: 69",
                            Created = new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 69"
                        },
                        new
                        {
                            Id = 70,
                            Content = "Content for Id: 70",
                            Created = new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 70"
                        },
                        new
                        {
                            Id = 71,
                            Content = "Content for Id: 71",
                            Created = new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 71"
                        },
                        new
                        {
                            Id = 72,
                            Content = "Content for Id: 72",
                            Created = new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 72"
                        },
                        new
                        {
                            Id = 73,
                            Content = "Content for Id: 73",
                            Created = new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 73"
                        },
                        new
                        {
                            Id = 74,
                            Content = "Content for Id: 74",
                            Created = new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 74"
                        },
                        new
                        {
                            Id = 75,
                            Content = "Content for Id: 75",
                            Created = new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 75"
                        },
                        new
                        {
                            Id = 76,
                            Content = "Content for Id: 76",
                            Created = new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 76"
                        },
                        new
                        {
                            Id = 77,
                            Content = "Content for Id: 77",
                            Created = new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 77"
                        },
                        new
                        {
                            Id = 78,
                            Content = "Content for Id: 78",
                            Created = new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 78"
                        },
                        new
                        {
                            Id = 79,
                            Content = "Content for Id: 79",
                            Created = new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 79"
                        },
                        new
                        {
                            Id = 80,
                            Content = "Content for Id: 80",
                            Created = new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 80"
                        },
                        new
                        {
                            Id = 81,
                            Content = "Content for Id: 81",
                            Created = new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 81"
                        },
                        new
                        {
                            Id = 82,
                            Content = "Content for Id: 82",
                            Created = new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 82"
                        },
                        new
                        {
                            Id = 83,
                            Content = "Content for Id: 83",
                            Created = new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 83"
                        },
                        new
                        {
                            Id = 84,
                            Content = "Content for Id: 84",
                            Created = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 84"
                        },
                        new
                        {
                            Id = 85,
                            Content = "Content for Id: 85",
                            Created = new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 85"
                        },
                        new
                        {
                            Id = 86,
                            Content = "Content for Id: 86",
                            Created = new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 86"
                        },
                        new
                        {
                            Id = 87,
                            Content = "Content for Id: 87",
                            Created = new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 87"
                        },
                        new
                        {
                            Id = 88,
                            Content = "Content for Id: 88",
                            Created = new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 88"
                        },
                        new
                        {
                            Id = 89,
                            Content = "Content for Id: 89",
                            Created = new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 89"
                        },
                        new
                        {
                            Id = 90,
                            Content = "Content for Id: 90",
                            Created = new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 90"
                        },
                        new
                        {
                            Id = 91,
                            Content = "Content for Id: 91",
                            Created = new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 91"
                        },
                        new
                        {
                            Id = 92,
                            Content = "Content for Id: 92",
                            Created = new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 92"
                        },
                        new
                        {
                            Id = 93,
                            Content = "Content for Id: 93",
                            Created = new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 93"
                        },
                        new
                        {
                            Id = 94,
                            Content = "Content for Id: 94",
                            Created = new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 94"
                        },
                        new
                        {
                            Id = 95,
                            Content = "Content for Id: 95",
                            Created = new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 95"
                        },
                        new
                        {
                            Id = 96,
                            Content = "Content for Id: 96",
                            Created = new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 96"
                        },
                        new
                        {
                            Id = 97,
                            Content = "Content for Id: 97",
                            Created = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 97"
                        },
                        new
                        {
                            Id = 98,
                            Content = "Content for Id: 98",
                            Created = new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 98"
                        },
                        new
                        {
                            Id = 99,
                            Content = "Content for Id: 99",
                            Created = new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 99"
                        },
                        new
                        {
                            Id = 100,
                            Content = "Content for Id: 100",
                            Created = new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local),
                            Title = "Title for Id: 100"
                        },
                        new
                        {
                            Id = 102,
                            Content = "Went hiking to Whistlers Mountain, but I just want to see what will happen to a long content",
                            Created = new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8083),
                            Title = "Went Hiking in Jasper, but I just want to see what will happen to a long title"
                        },
                        new
                        {
                            Id = 103,
                            Content = "Went shopping to Hinton, but I just want to see what will happen to a long content",
                            Created = new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8086),
                            Title = "Went Shopping, but I just want to see what will happen to a long title"
                        },
                        new
                        {
                            Id = 104,
                            Content = "Went driving to Jasper Driver's school, but I just want to see what will happen to a long content",
                            Created = new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8088),
                            Title = "Went Driving, but I just want to see what will happen to a long title"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
