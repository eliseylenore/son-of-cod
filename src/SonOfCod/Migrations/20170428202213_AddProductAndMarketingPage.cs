using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SonOfCod.Migrations
{
    public partial class AddProductAndMarketingPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketingPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BannerImageUrl = table.Column<string>(nullable: true),
                    BannerTitle = table.Column<string>(nullable: true),
                    NewsImageUrl = table.Column<string>(nullable: true),
                    NewsSummary = table.Column<string>(nullable: true),
                    NewsTitle = table.Column<string>(nullable: true),
                    ProductsTitle = table.Column<string>(nullable: true),
                    SummaryImageUrl = table.Column<string>(nullable: true),
                    SummaryText = table.Column<string>(nullable: true),
                    SummaryTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketingPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    MarketingPageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_MarketingPages_MarketingPageId",
                        column: x => x.MarketingPageId,
                        principalTable: "MarketingPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarketingPageId",
                table: "Products",
                column: "MarketingPageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MarketingPages");
        }
    }
}
