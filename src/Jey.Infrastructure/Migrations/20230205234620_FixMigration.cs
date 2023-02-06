using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jey.Infrastructure.Migrations
{
    public partial class FixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnnouncementName = table.Column<string>(type: "TEXT", nullable: false),
                    AnnouncementsQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    AnnouncementValue = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    UserIdAnnouncement = table.Column<ulong>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementId);
                    table.ForeignKey(
                        name: "FK_Announcements_User_UserIdAnnouncement",
                        column: x => x.UserIdAnnouncement,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    Id = table.Column<ulong>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerID = table.Column<ulong>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ItemKeyOrLink = table.Column<string>(type: "TEXT", nullable: false),
                    ItemDescription = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Jcoin = table.Column<int>(type: "INTEGER", nullable: false),
                    Scoin = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ItemKeyOrLink);
                });

            migrationBuilder.CreateTable(
                name: "SalesHistory",
                columns: table => new
                {
                    Date_sale = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Coins = table.Column<int>(type: "INTEGER", nullable: false),
                    SellTo = table.Column<ulong>(type: "INTEGER", nullable: false),
                    ItemDescription = table.Column<string>(type: "TEXT", nullable: false),
                    ItemKeyOrLink = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_SalesHistory_items_ItemKeyOrLink",
                        column: x => x.ItemKeyOrLink,
                        principalTable: "items",
                        principalColumn: "ItemKeyOrLink",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesHistory_User_SellTo",
                        column: x => x.SellTo,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_UserIdAnnouncement",
                table: "Announcements",
                column: "UserIdAnnouncement");

            migrationBuilder.CreateIndex(
                name: "IX_SalesHistory_ItemKeyOrLink",
                table: "SalesHistory",
                column: "ItemKeyOrLink");

            migrationBuilder.CreateIndex(
                name: "IX_SalesHistory_SellTo",
                table: "SalesHistory",
                column: "SellTo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Guilds");

            migrationBuilder.DropTable(
                name: "SalesHistory");

            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
