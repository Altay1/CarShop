using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Shop.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Volkswagen Golf is a compact car.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "Electric five-door liftback sedan.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "Sports car developed by BMW.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Volkswagen Golf is a compact car produced by the German automotive manufacturer Volkswagen since 1974");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "The Tesla Model S is an all-electric five-door liftback sedan, produced by Tesla, Inc.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "The BMW i8 is a plug-in hybrid sports car developed by BMW.");
        }
    }
}
