using Microsoft.EntityFrameworkCore.Migrations;

namespace WineGuideApp.Migrations
{
    public partial class Initial_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SetMashId",
                table: "set_mash_interaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "set_mash",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "recipe_ingredients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_set_mash_interaction_SetMashId",
                table: "set_mash_interaction",
                column: "SetMashId");

            migrationBuilder.CreateIndex(
                name: "IX_set_mash_RecipeId",
                table: "set_mash",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_recipe_ingredients_RecipeId",
                table: "recipe_ingredients",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_recipe_ingredients_recipe_RecipeId",
                table: "recipe_ingredients",
                column: "RecipeId",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_set_mash_recipe_RecipeId",
                table: "set_mash",
                column: "RecipeId",
                principalTable: "recipe",
                principalColumn: "recipe_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_set_mash_interaction_set_mash_SetMashId",
                table: "set_mash_interaction",
                column: "SetMashId",
                principalTable: "set_mash",
                principalColumn: "set_mash_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_recipe_ingredients_recipe_RecipeId",
                table: "recipe_ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_set_mash_recipe_RecipeId",
                table: "set_mash");

            migrationBuilder.DropForeignKey(
                name: "FK_set_mash_interaction_set_mash_SetMashId",
                table: "set_mash_interaction");

            migrationBuilder.DropIndex(
                name: "IX_set_mash_interaction_SetMashId",
                table: "set_mash_interaction");

            migrationBuilder.DropIndex(
                name: "IX_set_mash_RecipeId",
                table: "set_mash");

            migrationBuilder.DropIndex(
                name: "IX_recipe_ingredients_RecipeId",
                table: "recipe_ingredients");

            migrationBuilder.DropColumn(
                name: "SetMashId",
                table: "set_mash_interaction");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "set_mash");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "recipe_ingredients");
        }
    }
}
