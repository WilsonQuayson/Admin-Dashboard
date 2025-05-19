using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DashboardAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExtendSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Performance" },
                values: new object[,]
                {
                    { new Guid("133d5eb7-a7a9-4097-9a51-7ead12cc06e5"), new DateTime(2002, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlotte.clark@example.com", "Charlotte", "Clark", 93 },
                    { new Guid("276b3000-721f-4b33-b038-38839697be18"), new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elijah.rodriguez@example.com", "Elijah", "Rodriguez", 41 },
                    { new Guid("331c952f-4d3b-4243-94de-4e3bdb3b24a3"), new DateTime(2001, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "amelia.garcia@example.com", "Amelia", "Garcia", 94 },
                    { new Guid("492958de-86b7-4c3e-be39-6622a965b412"), new DateTime(2003, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "olivia.taylor@example.com", "Olivia", "Taylor", 70 },
                    { new Guid("618bdbbb-86d0-4749-92de-878db697a9a9"), new DateTime(1998, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.martinez@example.com", "Benjamin", "Martinez", 52 },
                    { new Guid("71dcdc95-a663-4b0b-b20c-0aa3fce11566"), new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane.smith@example.com", "Jane", "Smith", 72 },
                    { new Guid("8ff96f4e-b13e-4c0e-b75e-1e8a0f5a626b"), new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "michael.brown@example.com", "Michael", "Brown", 85 },
                    { new Guid("9fed3e16-c8e2-4091-aa33-4b1c0375400e"), new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.anderson@example.com", "Isabella", "Anderson", 89 },
                    { new Guid("a71109d6-32c6-4b1e-a29a-d8838024aacb"), new DateTime(2003, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "mia.martins@example.com", "Mia", "Martins", 97 },
                    { new Guid("aa6f7354-97e2-49ab-bafe-8262c8ad70bd"), new DateTime(1997, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "william.moore@example.com", "William", "Moore", 65 },
                    { new Guid("bf0ff508-2da9-4788-beb6-a85efc595b20"), new DateTime(2001, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "liam.wilson@example.com", "Liam", "Wilson", 37 },
                    { new Guid("cd10cbc5-94ae-427d-8292-ad46a301cf21"), new DateTime(2002, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.davis@example.com", "Sophia", "Davis", 95 },
                    { new Guid("d636d013-837e-49ee-baf4-1f2a6a135d7c"), new DateTime(2001, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.johnson@example.com", "Emily", "Johnson", 20 },
                    { new Guid("e5ed13fc-482c-49ed-8d6c-9cb8651d9633"), new DateTime(1999, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.harris@example.com", "James", "Harris", 87 },
                    { new Guid("f5936924-b385-4a11-8039-551886413ab0"), new DateTime(2000, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", "John", "Doe", 55 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("133d5eb7-a7a9-4097-9a51-7ead12cc06e5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("276b3000-721f-4b33-b038-38839697be18"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("331c952f-4d3b-4243-94de-4e3bdb3b24a3"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("492958de-86b7-4c3e-be39-6622a965b412"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("618bdbbb-86d0-4749-92de-878db697a9a9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("71dcdc95-a663-4b0b-b20c-0aa3fce11566"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8ff96f4e-b13e-4c0e-b75e-1e8a0f5a626b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9fed3e16-c8e2-4091-aa33-4b1c0375400e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("a71109d6-32c6-4b1e-a29a-d8838024aacb"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("aa6f7354-97e2-49ab-bafe-8262c8ad70bd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("bf0ff508-2da9-4788-beb6-a85efc595b20"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("cd10cbc5-94ae-427d-8292-ad46a301cf21"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d636d013-837e-49ee-baf4-1f2a6a135d7c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("e5ed13fc-482c-49ed-8d6c-9cb8651d9633"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f5936924-b385-4a11-8039-551886413ab0"));

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
    }
}
