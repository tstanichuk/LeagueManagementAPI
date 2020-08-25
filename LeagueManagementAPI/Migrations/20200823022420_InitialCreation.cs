using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LeagueManagementAPI.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    login_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(nullable: false),
                    password_hash = table.Column<string>(nullable: false),
                    password_salt = table.Column<string>(nullable: false),
                    password_hash_algorithm = table.Column<string>(nullable: false),
                    parent_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.login_id);
                });

            migrationBuilder.CreateTable(
                name: "parent",
                columns: table => new
                {
                    parent_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(nullable: false),
                    last_name = table.Column<string>(nullable: false),
                    address_id = table.Column<int>(nullable: false),
                    phone = table.Column<string>(nullable: false),
                    email = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parent", x => x.parent_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "parent");
        }
    }
}
