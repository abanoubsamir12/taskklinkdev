using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskk.Migrations
{
    /// <inheritdoc />
    public partial class newContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "brand",
                table: "tvs");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "ssystems");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "laptops");

            migrationBuilder.AddColumn<int>(
                name: "discount",
                table: "tvs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discount",
                table: "ssystems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "discount",
                table: "laptops",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discount",
                table: "tvs");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "ssystems");

            migrationBuilder.DropColumn(
                name: "discount",
                table: "laptops");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "tvs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "ssystems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "laptops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
