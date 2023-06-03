using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eUprava.Migrations
{
    /// <inheritdoc />
    public partial class Vloga_attributes_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusVloge",
                table: "Vloge",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusVloge",
                table: "Vloge");
        }
    }
}
