using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountErp.DataLayer.Migrations
{
    public partial class methodtermChangeInInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentTerm",
                table: "Invoices",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Invoices",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShippingMethod",
                table: "Invoices",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShippingTerm",
                table: "Invoices",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentTerm",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingAddress",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingMethod",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ShippingTerm",
                table: "Invoices");
        }
    }
}
