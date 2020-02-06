using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Notes_Practice.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "DateTime", "Title" },
                values: new object[,]
                {
                    { 1, "Work Stuff a lot todo's", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stuff To do" },
                    { 2, "Chill Mode is On.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vacation in Bahamas" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "Personal" },
                    { 2, "Work" },
                    { 3, "Vacation" }
                });

            migrationBuilder.InsertData(
                table: "TaggedNotes",
                columns: new[] { "TagId", "NoteId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "TaggedNotes",
                columns: new[] { "TagId", "NoteId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "TaggedNotes",
                columns: new[] { "TagId", "NoteId" },
                values: new object[] { 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TaggedNotes",
                keyColumns: new[] { "TagId", "NoteId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TaggedNotes",
                keyColumns: new[] { "TagId", "NoteId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "TaggedNotes",
                keyColumns: new[] { "TagId", "NoteId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
