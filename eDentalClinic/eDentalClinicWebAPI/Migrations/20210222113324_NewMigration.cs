using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalClinicWebAPI.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DentistBranches");

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Dentists",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "mAivLZDrlPwPpuLuFAm9kJfYzws=", "sff+idK26odwR3t5snG+oQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Dentists_BranchID",
                table: "Dentists",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dentists_Branches_BranchID",
                table: "Dentists",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dentists_Branches_BranchID",
                table: "Dentists");

            migrationBuilder.DropIndex(
                name: "IX_Dentists_BranchID",
                table: "Dentists");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Dentists");

            migrationBuilder.CreateTable(
                name: "DentistBranches",
                columns: table => new
                {
                    DentistBranchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BranchID = table.Column<int>(nullable: false),
                    DentistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DentistBranches", x => x.DentistBranchID);
                    table.ForeignKey(
                        name: "FK_DentistBranches_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DentistBranches_Dentists_DentistID",
                        column: x => x.DentistID,
                        principalTable: "Dentists",
                        principalColumn: "DentistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "dKMD2UfzF+8CTQ6XplF1Pphtr4M=", "SDqVKWa7AIbDbAvgWhdHvQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_DentistBranches_BranchID",
                table: "DentistBranches",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_DentistBranches_DentistID",
                table: "DentistBranches",
                column: "DentistID");
        }
    }
}
