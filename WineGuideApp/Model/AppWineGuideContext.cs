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
        public DbSet<UserAccount_Recipe> UserAccount_Recipes {get; set;}
        public DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public DbSet<SetMash> SetMashes { get; set; }
        public DbSet<SetMashInteraction> SetMashInteractions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VBT0UP6\BAZADANYCHSQL;Database=WineGuideDatabase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //UserAccount-Recipe ManyToMany
            modelBuilder.Entity<UserAccount_Recipe>()
                .HasKey(UaR => new { UaR.UserAccountId, UaR.RecipeId });

            modelBuilder.Entity<UserAccount_Recipe>()
                 .HasOne(UaR => UaR.Recipe)
                 .WithMany(r => r.UserAccount_Recipes)
                 .HasForeignKey(UaR => UaR.RecipeId);

            modelBuilder.Entity<UserAccount_Recipe>()
                .HasOne(UaR => UaR.UserAccount)
                .WithMany(ua => ua.UserAccount_Recipes)
                .HasForeignKey(UaR => UaR.UserAccountId);


            //Recipe-RecipeIngredients OneToMany
            modelBuilder.Entity<RecipeIngredients>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);


            //Recipe-SetMash OneToMany
            modelBuilder.Entity<SetMash>()
                .HasOne(s => s.Recipe)
                .WithMany(r => r.SetMashes)
                .HasForeignKey(s => s.RecipeId);


            //SetMash-SetMeshInteraction OneToMany
            modelBuilder.Entity<SetMashInteraction>()
                .HasOne(si => si.SetMash)
                .WithMany(sm => sm.SetMashInteraction)
                .HasForeignKey(si => si.SetMashId);
        }
    }

    
}
