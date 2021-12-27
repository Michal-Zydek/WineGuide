using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WineGuideApp.Migrations
{
    public partial class Initial_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipe",
                columns: table => new
                {
                    recipe_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipe_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recipe_type_alcohol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe", x => x.recipe_id);
                });

            migrationBuilder.CreateTable(
                name: "recipe_ingredients",
                columns: table => new
                {
                    recipe_ingredients_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    recipe_ingredients_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    recipe_ingredients_type_of_quantity = table.Column<int>(type: "int", nullable: false),
                    recipe_ingredients_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipe_ingredients", x => x.recipe_ingredients_id);
                });

            migrationBuilder.CreateTable(
                name: "set_mash",
                columns: table => new
                {
                    set_mash_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    set_mash_start = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_set_mash", x => x.set_mash_id);
                });

            migrationBuilder.CreateTable(
                name: "set_mash_interaction",
                columns: table => new
                {
                    set_mash_interaction_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    set_mash_interaction_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    set_mash_interaction_type_of_quantity = table.Column<int>(type: "int", nullable: false),
                    set_mash_interaction_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_set_mash_interaction", x => x.set_mash_interaction_id);
                });

            migrationBuilder.CreateTable(
                name: "user_account",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    account_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    account_password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_account", x => x.account_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipe");

            migrationBuilder.DropTable(
                name: "recipe_ingredients");

            migrationBuilder.DropTable(
                name: "set_mash");

            migrationBuilder.DropTable(
                name: "set_mash_interaction");

            migrationBuilder.DropTable(
                name: "user_account");
        }
    }
}
