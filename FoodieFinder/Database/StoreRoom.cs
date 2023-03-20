using Java.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace FoodieFinder.Database
{
    public class StoreRoom
    {
        [Column("ProductId")]
        public int Id { get; set; }

        [Column("ProductName")]
        public string Name { get; set; }
        public DateOnly ExpirationDate { get; set; }

        [Column("User_UserId")]
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
    }

    public class StoreRoomContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<StoreRoom> StoreRoom { get; set; }
        public StoreRoomContext()
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
