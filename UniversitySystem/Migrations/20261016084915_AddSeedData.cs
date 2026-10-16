using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniversitySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "UniversityId", "Address", "Name" },
                values: new object[] { 1, "Sohag, Egypt", "Sohag University" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "Name", "PhoneNumber", "UniversityId" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali@student.com", "Ali Hassan", "01112345678", 1 },
                    { 2, new DateTime(2004, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "sara@student.com", "Sara Ahmed", "01112345679", 1 },
                    { 3, new DateTime(2005, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar@student.com", "Omar Khaled", "01112345680", 1 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Email", "Name", "PhoneNumber", "Salary", "UniversityId" },
                values: new object[,]
                {
                    { 1, "ahmed@university.com", "Ahmed Mohamed", "01012345678", 15000m, 1 },
                    { 2, "mona@university.com", "Mona Ali", "01012345679", 18000m, 1 },
                    { 3, "mahmoud@university.com", "Mahmoud Hassan", "01012345680", 17000m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CreditsHours", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, 3, "C# Programming", 1 },
                    { 2, 4, "Database Systems", 2 },
                    { 3, 3, "Web Development", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Universities",
                keyColumn: "UniversityId",
                keyValue: 1);
        }
    }
}
