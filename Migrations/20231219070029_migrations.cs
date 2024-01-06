using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taufik_Hasan.Migrations
{
    /// <inheritdoc />
    public partial class migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInformation",
                table: "PersonalInformation");

            migrationBuilder.RenameTable(
                name: "PersonalInformation",
                newName: "PersonalInformations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInformations",
                table: "PersonalInformations",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonalInformations",
                table: "PersonalInformations");

            migrationBuilder.RenameTable(
                name: "PersonalInformations",
                newName: "PersonalInformation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonalInformation",
                table: "PersonalInformation",
                column: "UserID");
        }
    }
}
