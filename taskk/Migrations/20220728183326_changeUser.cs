using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskk.Migrations
{
    /// <inheritdoc />
    public partial class changeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "users",
                newName: "Pwd");

            migrationBuilder.AddColumn<string>(
                name: "Confirmpwd",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmpwd",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Pwd",
                table: "users",
                newName: "FirstName");
        }
    }
}
