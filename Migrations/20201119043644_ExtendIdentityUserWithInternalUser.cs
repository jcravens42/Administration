using Microsoft.EntityFrameworkCore.Migrations;

namespace Administration.Migrations
{
    public partial class ExtendIdentityUserWithInternalUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InternalUser",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalUser",
                table: "AspNetUsers");
        }
    }
}
