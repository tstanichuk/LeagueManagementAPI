using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LeagueManagementAPI.Migrations
{
    public partial class PeopleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    address_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    street = table.Column<string>(nullable: false),
                    apartment_number = table.Column<string>(nullable: true),
                    zip_code_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address", x => x.address_id);
                });

            migrationBuilder.CreateTable(
                name: "child",
                columns: table => new
                {
                    child_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(nullable: false),
                    last_name = table.Column<string>(nullable: false),
                    birthdate = table.Column<DateTime>(nullable: false),
                    gender = table.Column<string>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_child", x => x.child_id);
                });

            migrationBuilder.CreateTable(
                name: "parent_child",
                columns: table => new
                {
                    parent_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    child_id = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parent_child", x => x.parent_id);
                });

            migrationBuilder.CreateTable(
                name: "zip_code",
                columns: table => new
                {
                    zip_code_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    postal_code = table.Column<string>(nullable: false),
                    city = table.Column<string>(nullable: false),
                    county_name = table.Column<string>(nullable: true),
                    state_id = table.Column<string>(nullable: false),
                    state_name = table.Column<string>(nullable: false),
                    timezone = table.Column<string>(nullable: true),
                    latitutde = table.Column<int>(nullable: false),
                    longitude = table.Column<int>(nullable: false),
                    population = table.Column<int>(nullable: false),
                    last_update = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zip_code", x => x.zip_code_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "child");

            migrationBuilder.DropTable(
                name: "parent_child");

            migrationBuilder.DropTable(
                name: "zip_code");
        }
    }
}
