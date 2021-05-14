using Microsoft.EntityFrameworkCore.Migrations;

namespace MuckScraperMVCApp.Migrations
{
    public partial class tertiary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "profilePhoto",
                table: "AspNetUsers",
                newName: "ProfilePhoto");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "ProfilePhoto",
                table: "AspNetUsers",
                newName: "profilePhoto");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "firstName");
        }
    }
}
