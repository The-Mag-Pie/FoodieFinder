using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace FoodieFinder.Database
{
    public class LikedRecipe
    {
        [Column("SavedId")]
        public int Id { get; set; }
        public string Link { get; set; }

        [Column("User_UserId")]
        public int UserId { get; set; }

    }

    public class LikedRecipeContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<LikedRecipe> LikedRecipe { get; set; }
        public LikedRecipeContext()
        {
            var a = Assembly.GetExecutingAssembly();
            using var stream = a.GetManifestResourceStream("FoodieFinder.appsettings.json");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonStream(stream)
                .Build();
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("MariaDbConnectionString");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
