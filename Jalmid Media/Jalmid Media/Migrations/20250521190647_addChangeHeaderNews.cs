using Microsoft.EntityFrameworkCore.Migrations;

namespace Jalmid_Media.Migrations
{
    public partial class addChangeHeaderNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HeaderNews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HeaderNews");
        }
    }
}
