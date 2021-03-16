using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentalClinicWebAPI.Migrations
{
    public partial class NewMigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Topics_TopicID",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "TopicID",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "V8Pb2va6dGwqVRopnECIYJ0MPV0=", "OEcrZgxZT2077SeWzOt0zg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Topics_TopicID",
                table: "Comments",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "TopicID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Topics_TopicID",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "TopicID",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "4jV+ggNAsN4YJWmfWFpeQlTycbg=", "uAIFjatTCiMQxuMwV/R9rg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Topics_TopicID",
                table: "Comments",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "TopicID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
