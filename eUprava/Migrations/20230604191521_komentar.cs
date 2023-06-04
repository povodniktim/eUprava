using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eUprava.Migrations
{
    /// <inheritdoc />
    public partial class komentar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Komentar",
                table: "Vloge",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Komentar",
                table: "Vloge");
        }
    }
}
