using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMyStuff.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToTPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Items_itemId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Items_itemId",
                table: "Pets");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "originalCost",
                table: "Pets",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "purchaseDate",
                table: "Pets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "userId",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "originalCost",
                table: "Documents",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "purchaseDate",
                table: "Documents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "userId",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Pets_userId",
                table: "Pets",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_userId",
                table: "Documents",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_userId",
                table: "Documents",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_userId",
                table: "Pets",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_userId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_userId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_userId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Documents_userId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "category",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "originalCost",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "purchaseDate",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "category",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "originalCost",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "purchaseDate",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Documents");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Items_itemId",
                table: "Documents",
                column: "itemId",
                principalTable: "Items",
                principalColumn: "itemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Items_itemId",
                table: "Pets",
                column: "itemId",
                principalTable: "Items",
                principalColumn: "itemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
