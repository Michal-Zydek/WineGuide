using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineGuide.Models;

namespace WineGuideApp.Model
{
    public class AppWineGuideContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<SetMash> SetMashes { get; set; }
        public DbSet<SetMashInteraction> SetMashInteractions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VBT0UP6\BAZADANYCHSQL;Database=WineGuideDatabase;Trusted_Connection=True;");
        }
    }

    
}
