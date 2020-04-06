using Microsoft.EntityFrameworkCore.Migrations;

namespace Car_Shop.Migrations
{
    public partial class thirdfixthumnailnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/golfeorig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/golfethumb.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsorig.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsthumb.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/golfethumb.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/golfeorig.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbImageUrl" },
                values: new object[] { "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsthumb.jpg", "https://raw.githubusercontent.com/Altay1/asdasd/master/teslamodelsorig.jpg" });
        }
    }
}
