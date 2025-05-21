using Microsoft.EntityFrameworkCore.Migrations;

namespace Jalmid_Media.Migrations
{
    public partial class addServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Title1 = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Title3 = table.Column<string>(nullable: true),
                    Title4 = table.Column<string>(nullable: true),
                    Title5 = table.Column<string>(nullable: true),
                    Title6 = table.Column<string>(nullable: true),
                    Title7 = table.Column<string>(nullable: true),
                    CheckIcon1 = table.Column<string>(nullable: true),
                    CheckIcon2 = table.Column<string>(nullable: true),
                    CheckIcon3 = table.Column<string>(nullable: true),
                    CheckIcon4 = table.Column<string>(nullable: true),
                    CheckIcon5 = table.Column<string>(nullable: true),
                    CheckIcon6 = table.Column<string>(nullable: true),
                    CheckIcon7 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
