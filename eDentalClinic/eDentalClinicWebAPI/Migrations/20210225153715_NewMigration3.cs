using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalClinicWebAPI.Migrations
{
    public partial class NewMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DentistID",
                table: "Comments",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/nWi6jXdcebvyxsQyf/N2pTcH6c=", "IXy/64UqIdbHYag972TZ3Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_DentistID",
                table: "Comments",
                column: "DentistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Dentists_DentistID",
                table: "Comments",
                column: "DentistID",
                principalTable: "Dentists",
                principalColumn: "DentistID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Dentists_DentistID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_DentistID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DentistID",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ikt4MQb1Nh+6F6ai3o+DmpX2jbE=", "fP8TLxDV3XbjK1EdIS1iPA==" });
        }
    }
}
