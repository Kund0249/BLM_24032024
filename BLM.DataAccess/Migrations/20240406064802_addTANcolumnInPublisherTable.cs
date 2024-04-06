using Microsoft.EntityFrameworkCore.Migrations;

namespace BLM.DataAccess.Migrations
{
    public partial class addTANcolumnInPublisherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TAN",
                table: "TPUBLISHER",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TAN",
                table: "TPUBLISHER");
        }
    }
}
