using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoSys_backend.Migrations
{
    /// <inheritdoc />
    public partial class addeduniqueUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uniqueUserId",
                table: "UsersTable",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uniqueUserId",
                table: "UsersTable");
        }
    }
}
