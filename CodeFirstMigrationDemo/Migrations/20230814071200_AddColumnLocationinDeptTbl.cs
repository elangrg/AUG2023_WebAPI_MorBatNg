using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstMigrationDemo.Migrations
{
    public partial class AddColumnLocationinDeptTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Departments",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Departments");
        }
    }
}
