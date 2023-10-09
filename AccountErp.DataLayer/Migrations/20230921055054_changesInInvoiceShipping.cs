using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountErp.DataLayer.Migrations
{
    public partial class changesInInvoiceShipping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipientName",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCity",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCompanyName",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCountry",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingPostalCode",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingState",
                table: "Invoices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingCity",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingCompanyName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingCountry",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingPostalCode",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingState",
                table: "Invoices");
        }
    }
}
