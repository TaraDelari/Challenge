using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 255, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.UniqueConstraint("AK_users_Email", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "webpages",
                columns: table => new
                {
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_webpages", x => x.Url);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_roles", x => new { x.UserId, x.RoleName });
                    table.ForeignKey(
                        name: "FK_user_roles_roles_RoleName",
                        column: x => x.RoleName,
                        principalTable: "roles",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_roles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "keywords",
                columns: table => new
                {
                    Word = table.Column<string>(nullable: false),
                    WebPageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keywords", x => new { x.Word, x.WebPageUrl });
                    table.ForeignKey(
                        name: "FK_keywords_webpages_WebPageUrl",
                        column: x => x.WebPageUrl,
                        principalTable: "webpages",
                        principalColumn: "Url",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "links",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    WebPageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_links", x => new { x.WebPageUrl, x.UserId });
                    table.ForeignKey(
                        name: "FK_links_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_links_webpages_WebPageUrl",
                        column: x => x.WebPageUrl,
                        principalTable: "webpages",
                        principalColumn: "Url",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Content = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false),
                    LinkUserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => new { x.Content, x.Url, x.LinkUserId });
                    table.ForeignKey(
                        name: "FK_tags_links_Url_LinkUserId",
                        columns: x => new { x.Url, x.LinkUserId },
                        principalTable: "links",
                        principalColumns: new[] { "WebPageUrl", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Name", "DisplayName" },
                values: new object[] { "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Name", "DisplayName" },
                values: new object[] { "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_keywords_WebPageUrl",
                table: "keywords",
                column: "WebPageUrl");

            migrationBuilder.CreateIndex(
                name: "IX_links_UserId",
                table: "links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tags_Url_LinkUserId",
                table: "tags",
                columns: new[] { "Url", "LinkUserId" });

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_RoleName",
                table: "user_roles",
                column: "RoleName");

            migrationBuilder.CreateIndex(
                name: "IX_users_Email",
                table: "users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keywords");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "links");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "webpages");
        }
    }
}
