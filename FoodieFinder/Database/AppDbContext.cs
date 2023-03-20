using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodieFinder.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<LikedRecipe> LikedRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<StoreRoom> StoreRoomItems { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            Database.EnsureCreated();
        }
    }
}
