using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMyStuff.API.Migrations
{
    /// <inheritdoc />
    public partial class FixingModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_userId1",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Users_userId1",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_userId1",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Documents_userId1",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "userId1",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "userId1",
                table: "Documents");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CS_AS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CS_AS");

            migrationBuilder.AddColumn<Guid>(
                name: "userId1",
                table: "Pets",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "userId1",
                table: "Documents",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_userId1",
                table: "Pets",
                column: "userId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_userId1",
                table: "Documents",
                column: "userId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_userId1",
                table: "Documents",
                column: "userId1",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Users_userId1",
                table: "Pets",
                column: "userId1",
                principalTable: "Users",
                principalColumn: "userId");
        }
    }
}
