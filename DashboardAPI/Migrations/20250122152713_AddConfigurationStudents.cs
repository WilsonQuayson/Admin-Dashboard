using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashboardAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddConfigurationStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("0bbd4019-3883-4f31-b02f-3188c87bed33"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3c38297a-0138-411e-9157-c258358d95bc"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("58f09c0e-0df7-47f9-a47c-43bb23a8f2c6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("88d75443-75df-4a0a-b814-74a309efa6d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a26b5a0f-7cdc-4dab-95b2-19dbb6406483"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Performance" },
                values: new object[,]
                {
                    { new Guid("24805f11-94b7-4604-ae88-1f9808523d17"), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", 92 },
                    { new Guid("c89c42ed-6728-48a9-a2a6-19c55dff1d24"), new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@example.com", "Emily", "Johnson", 78 },
                    { new Guid("da30e7ed-3aeb-4af3-b46e-64df15490915"), new DateTime(2002, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.davis@example.com", "Sophia", "Davis", 95 },
                    { new Guid("edfa6e75-9d0d-4c57-8c2d-377d2d6fe25c"), new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", 85 },
                    { new Guid("f7f96b88-ca00-4e6e-85a1-f328c24ae237"), new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", "Michael", "Brown", 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("24805f11-94b7-4604-ae88-1f9808523d17"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c89c42ed-6728-48a9-a2a6-19c55dff1d24"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("da30e7ed-3aeb-4af3-b46e-64df15490915"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("edfa6e75-9d0d-4c57-8c2d-377d2d6fe25c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f7f96b88-ca00-4e6e-85a1-f328c24ae237"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Performance" },
                values: new object[,]
                {
                    { new Guid("0bbd4019-3883-4f31-b02f-3188c87bed33"), new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", "Michael", "Brown", 88 },
                    { new Guid("3c38297a-0138-411e-9157-c258358d95bc"), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", 92 },
                    { new Guid("58f09c0e-0df7-47f9-a47c-43bb23a8f2c6"), new DateTime(2002, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.davis@example.com", "Sophia", "Davis", 95 },
                    { new Guid("88d75443-75df-4a0a-b814-74a309efa6d7"), new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@example.com", "Emily", "Johnson", 78 },
                    { new Guid("a26b5a0f-7cdc-4dab-95b2-19dbb6406483"), new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", 85 }
                });
        }
    }
}
