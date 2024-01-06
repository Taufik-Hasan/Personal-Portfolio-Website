using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taufik_Hasan.Migrations
{
    /// <inheritdoc />
    public partial class imageMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "PersonalInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "PersonalInformations");
        }
    }
}
