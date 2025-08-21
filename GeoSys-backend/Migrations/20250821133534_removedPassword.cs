using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoSys_backend.Migrations
{
    /// <inheritdoc />
    public partial class removedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_password",
                table: "UsersTable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_password",
                table: "UsersTable",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
