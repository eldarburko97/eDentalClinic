using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalClinicWebAPI.Migrations
{
    public partial class NewMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Treatments_TreatmentID",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Users_UserID",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_UserID",
                table: "Payments",
                newName: "IX_Payments_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_TreatmentID",
                table: "Payments",
                newName: "IX_Payments_TreatmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentID");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4jV+ggNAsN4YJWmfWFpeQlTycbg=", "uAIFjatTCiMQxuMwV/R9rg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Treatments_TreatmentID",
                table: "Payments",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserID",
                table: "Payments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Treatments_TreatmentID",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserID",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserID",
                table: "Payment",
                newName: "IX_Payment_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_TreatmentID",
                table: "Payment",
                newName: "IX_Payment_TreatmentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "PaymentID");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "S1TgZq0N0uCxI14Pu+bzahVQm6c=", "s8JLOpMPm8K/VdQYV+JCdA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Treatments_TreatmentID",
                table: "Payment",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Users_UserID",
                table: "Payment",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
