using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Todean_Daiana_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Author",
                newName: "ID");
        }
    }
}
