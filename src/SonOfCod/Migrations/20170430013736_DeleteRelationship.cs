using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCod.Migrations
{
    public partial class DeleteRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MarketingPages_MarketingPageId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MarketingPageId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MarketingPageId",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarketingPageId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarketingPageId",
                table: "Products",
                column: "MarketingPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MarketingPages_MarketingPageId",
                table: "Products",
                column: "MarketingPageId",
                principalTable: "MarketingPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
