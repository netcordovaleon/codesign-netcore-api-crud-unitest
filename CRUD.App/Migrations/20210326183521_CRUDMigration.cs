using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.App.Migrations
{
    public partial class CRUDMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tproducts",
                columns: table => new
                {
                    prdid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prdname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prddescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prdstock = table.Column<int>(type: "int", nullable: false),
                    prdprice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    prdcategory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tproducts", x => x.prdid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tproducts");
        }
    }
}
