using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMyStuff.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    itemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    originalCost = table.Column<double>(type: "float", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    documentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_Documents_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Users_userId1",
                        column: x => x.userId1,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    itemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    originalCost = table.Column<double>(type: "float", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_Items_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    itemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    originalCost = table.Column<double>(type: "float", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    userId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_Pets_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_Users_userId1",
                        column: x => x.userId1,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_userId",
                table: "Documents",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_userId1",
                table: "Documents",
                column: "userId1");

            migrationBuilder.CreateIndex(
                name: "IX_Items_userId",
                table: "Items",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_userId",
                table: "Pets",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_userId1",
                table: "Pets",
                column: "userId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
