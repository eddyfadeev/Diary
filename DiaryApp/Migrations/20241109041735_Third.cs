using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DiaryEntries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "DiaryEntries",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Content for Id: 1", new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 1" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Content for Id: 2", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 2" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Content for Id: 3", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 3" });

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 4, "Content for Id: 4", new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 4" },
                    { 5, "Content for Id: 5", new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 5" },
                    { 6, "Content for Id: 6", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 6" },
                    { 7, "Content for Id: 7", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 7" },
                    { 8, "Content for Id: 8", new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 8" },
                    { 9, "Content for Id: 9", new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 9" },
                    { 10, "Content for Id: 10", new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 10" },
                    { 11, "Content for Id: 11", new DateTime(2024, 9, 7, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 11" },
                    { 12, "Content for Id: 12", new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 12" },
                    { 13, "Content for Id: 13", new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 13" },
                    { 14, "Content for Id: 14", new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 14" },
                    { 15, "Content for Id: 15", new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 15" },
                    { 16, "Content for Id: 16", new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 16" },
                    { 17, "Content for Id: 17", new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 17" },
                    { 18, "Content for Id: 18", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 18" },
                    { 19, "Content for Id: 19", new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 19" },
                    { 20, "Content for Id: 20", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 20" },
                    { 21, "Content for Id: 21", new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 21" },
                    { 22, "Content for Id: 22", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 22" },
                    { 23, "Content for Id: 23", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 23" },
                    { 24, "Content for Id: 24", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 24" },
                    { 25, "Content for Id: 25", new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 25" },
                    { 26, "Content for Id: 26", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 26" },
                    { 27, "Content for Id: 27", new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 27" },
                    { 28, "Content for Id: 28", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 28" },
                    { 29, "Content for Id: 29", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 29" },
                    { 30, "Content for Id: 30", new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 30" },
                    { 31, "Content for Id: 31", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 31" },
                    { 32, "Content for Id: 32", new DateTime(2024, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 32" },
                    { 33, "Content for Id: 33", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 33" },
                    { 34, "Content for Id: 34", new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 34" },
                    { 35, "Content for Id: 35", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 35" },
                    { 36, "Content for Id: 36", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 36" },
                    { 37, "Content for Id: 37", new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 37" },
                    { 38, "Content for Id: 38", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 38" },
                    { 39, "Content for Id: 39", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 39" },
                    { 40, "Content for Id: 40", new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 40" },
                    { 41, "Content for Id: 41", new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 41" },
                    { 42, "Content for Id: 42", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 42" },
                    { 43, "Content for Id: 43", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 43" },
                    { 44, "Content for Id: 44", new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 44" },
                    { 45, "Content for Id: 45", new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 45" },
                    { 46, "Content for Id: 46", new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 46" },
                    { 47, "Content for Id: 47", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 47" },
                    { 48, "Content for Id: 48", new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 48" },
                    { 49, "Content for Id: 49", new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 49" },
                    { 50, "Content for Id: 50", new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 50" },
                    { 51, "Content for Id: 51", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 51" },
                    { 52, "Content for Id: 52", new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 52" },
                    { 53, "Content for Id: 53", new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 53" },
                    { 54, "Content for Id: 54", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 54" },
                    { 55, "Content for Id: 55", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 55" },
                    { 56, "Content for Id: 56", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 56" },
                    { 57, "Content for Id: 57", new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 57" },
                    { 58, "Content for Id: 58", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 58" },
                    { 59, "Content for Id: 59", new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 59" },
                    { 60, "Content for Id: 60", new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 60" },
                    { 61, "Content for Id: 61", new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 61" },
                    { 62, "Content for Id: 62", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 62" },
                    { 63, "Content for Id: 63", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 63" },
                    { 64, "Content for Id: 64", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 64" },
                    { 65, "Content for Id: 65", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 65" },
                    { 66, "Content for Id: 66", new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 66" },
                    { 67, "Content for Id: 67", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 67" },
                    { 68, "Content for Id: 68", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 68" },
                    { 69, "Content for Id: 69", new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 69" },
                    { 70, "Content for Id: 70", new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 70" },
                    { 71, "Content for Id: 71", new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 71" },
                    { 72, "Content for Id: 72", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 72" },
                    { 73, "Content for Id: 73", new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 73" },
                    { 74, "Content for Id: 74", new DateTime(2024, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 74" },
                    { 75, "Content for Id: 75", new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 75" },
                    { 76, "Content for Id: 76", new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 76" },
                    { 77, "Content for Id: 77", new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 77" },
                    { 78, "Content for Id: 78", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 78" },
                    { 79, "Content for Id: 79", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 79" },
                    { 80, "Content for Id: 80", new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 80" },
                    { 81, "Content for Id: 81", new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 81" },
                    { 82, "Content for Id: 82", new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 82" },
                    { 83, "Content for Id: 83", new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 83" },
                    { 84, "Content for Id: 84", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 84" },
                    { 85, "Content for Id: 85", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 85" },
                    { 86, "Content for Id: 86", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 86" },
                    { 87, "Content for Id: 87", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 87" },
                    { 88, "Content for Id: 88", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 88" },
                    { 89, "Content for Id: 89", new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 89" },
                    { 90, "Content for Id: 90", new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 90" },
                    { 91, "Content for Id: 91", new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 91" },
                    { 92, "Content for Id: 92", new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 92" },
                    { 93, "Content for Id: 93", new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 93" },
                    { 94, "Content for Id: 94", new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 94" },
                    { 95, "Content for Id: 95", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 95" },
                    { 96, "Content for Id: 96", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 96" },
                    { 97, "Content for Id: 97", new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 97" },
                    { 98, "Content for Id: 98", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 98" },
                    { 99, "Content for Id: 99", new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 99" },
                    { 100, "Content for Id: 100", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Local), "Title for Id: 100" },
                    { 102, "Went hiking to Whistlers Mountain, but I just want to see what will happen to a long content", new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8083), "Went Hiking in Jasper, but I just want to see what will happen to a long title" },
                    { 103, "Went shopping to Hinton, but I just want to see what will happen to a long content", new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8086), "Went Shopping, but I just want to see what will happen to a long title" },
                    { 104, "Went driving to Jasper Driver's school, but I just want to see what will happen to a long content", new DateTime(2024, 11, 8, 21, 17, 35, 23, DateTimeKind.Local).AddTicks(8088), "Went Driving, but I just want to see what will happen to a long title" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "DiaryEntries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "DiaryEntries",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Went hiking to Whistlers Mountain", new DateTime(2024, 11, 3, 12, 3, 35, 434, DateTimeKind.Local).AddTicks(9701), "Went Hiking" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Went shopping to Hinton", new DateTime(2024, 11, 3, 12, 3, 35, 434, DateTimeKind.Local).AddTicks(9942), "Went Shopping" });

            migrationBuilder.UpdateData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Created", "Title" },
                values: new object[] { "Went driving to Jasper Driver's school", new DateTime(2024, 11, 3, 12, 3, 35, 434, DateTimeKind.Local).AddTicks(9946), "Went Driving" });
        }
    }
}
