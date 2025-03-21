using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieBuzz.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifyMovieTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "MovieName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieName",
                table: "Movies",
                newName: "Name");
        }
    }
}
