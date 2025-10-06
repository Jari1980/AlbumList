using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlbumList.Migrations
{
    /// <inheritdoc />
    public partial class modelUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Album",
                newName: "Band");

            migrationBuilder.AddColumn<string>(
                name: "AlbumName",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumName",
                table: "Album");

            migrationBuilder.RenameColumn(
                name: "Band",
                table: "Album",
                newName: "Name");
        }
    }
}
