using Microsoft.EntityFrameworkCore.Migrations;

namespace PivotTableinMVCCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GetInvoices",
                columns: table => new
                {
                    InvoiceNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(nullable: false),
                    CostCategory = table.Column<string>(nullable: true),
                    Period = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetInvoices", x => x.InvoiceNumber);
                });

            migrationBuilder.InsertData(
                table: "GetInvoices",
                columns: new[] { "InvoiceNumber", "Amount", "CostCategory", "Period" },
                values: new object[,]
                {
                    { 1, 10.0, "testing", "2019_11" },
                    { 2, 20.0, "sales2", "2019_11" },
                    { 3, 30.0, "testing", "2019_12" },
                    { 4, 40.0, "sales4", "2019_12" },
                    { 5, 10.0, "sales2", "2019_11" },
                    { 6, 20.0, "testing", "2019_11" },
                    { 7, 30.0, "utilitis", "2019_12" },
                    { 8, 40.0, "utilitis", "2019_12" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GetInvoices");
        }
    }
}
