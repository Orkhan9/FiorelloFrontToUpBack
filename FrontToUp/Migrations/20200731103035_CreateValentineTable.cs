using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToUp.Migrations
{
    public partial class CreateValentineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Valentines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MainImage = table.Column<string>(nullable: true),
                    ImageIcon = table.Column<string>(nullable: true),
                    MainTitle = table.Column<string>(nullable: true),
                    MainText = table.Column<string>(nullable: true),
                    HeartImage = table.Column<string>(nullable: true),
                    HeartText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valentines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Valentines");
        }
    }
}
