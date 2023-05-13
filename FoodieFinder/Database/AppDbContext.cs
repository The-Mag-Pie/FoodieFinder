using Microsoft.EntityFrameworkCore;

namespace FoodieFinder.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<LikedRecipe> LikedRecipe { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<StorageItem> StoreRoom { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<OnlineRecipe> OnlineRecipe { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
