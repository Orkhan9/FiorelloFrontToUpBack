using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToUp.Migrations
{
    public partial class ChangeValentineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeartImage",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "HeartText",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "MainImage",
                table: "Valentines");

            migrationBuilder.RenameColumn(
                name: "MainTitle",
                table: "Valentines",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "MainText",
                table: "Valentines",
                newName: "HeartList");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Valentines",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Valentines",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Valentines",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Valentines");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Valentines");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Valentines",
                newName: "MainTitle");

            migrationBuilder.RenameColumn(
                name: "HeartList",
                table: "Valentines",
                newName: "MainText");

            migrationBuilder.AddColumn<string>(
                name: "HeartImage",
                table: "Valentines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeartText",
                table: "Valentines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainImage",
                table: "Valentines",
                nullable: true);
        }
    }
}
