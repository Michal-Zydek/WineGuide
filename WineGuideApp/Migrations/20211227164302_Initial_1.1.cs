using Microsoft.EntityFrameworkCore.Migrations;

namespace WineGuideApp.Migrations
{
    public partial class Initial_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccount_Recipes",
                columns: table => new
                {
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccount_Recipes", x => new { x.UserAccountId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_UserAccount_Recipes_recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "recipe",
                        principalColumn: "recipe_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAccount_Recipes_user_account_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "user_account",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccount_Recipes_RecipeId",
                table: "UserAccount_Recipes",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccount_Recipes");
        }
    }
}
