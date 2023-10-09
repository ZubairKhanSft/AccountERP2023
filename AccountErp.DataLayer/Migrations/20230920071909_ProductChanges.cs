using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountErp.DataLayer.Migrations
{
    public partial class ProductChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UAN",
                table: "Products",
                newName: "UPC");

            migrationBuilder.AlterColumn<string>(
                name: "SupplierCode",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UPC",
                table: "Products",
                newName: "UAN");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierCode",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "PartNumber",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
