using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashboardAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
