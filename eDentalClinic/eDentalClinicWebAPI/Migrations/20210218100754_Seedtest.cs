using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalClinicWebAPI.Migrations
{
    public partial class Seedtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "BirthDate", "CityID", "DentalClinicID", "Email", "FirstName", "GenderID", "Image", "LastName", "PasswordHash", "PasswordSalt", "Phone", "Username" },
                values: new object[] { 1, "Lamele", new DateTime(1997, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "william@mail.com", "William", 1, null, "Shakespeare", "iFtP7lw3d/kIyRwu/r3ZNY7CkYM=", "l4X26fhx/gWyFhGCNSpITQ==", "062440876", "William" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);
        }
    }
}
