using Java.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace FoodieFinder.Database
{
    public class User
    {
        [Column("UserId")]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
    }

    //public class UserContext : DbContext
    //{
    //    private readonly IConfiguration _configuration;
    //    public DbSet<User> User { get; set; }
    //    public UserContext()
    //    {
    //        var a = Assembly.GetExecutingAssembly();
    //        using var stream = a.GetManifestResourceStream("FoodieFinder.appsettings.json");

    //        IConfigurationRoot configuration = new ConfigurationBuilder()
    //            .AddJsonStream(stream)
    //            .Build();
    //        _configuration = configuration;
    //    }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        var connectionString = _configuration.GetConnectionString("MariaDbConnectionString");
    //        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    //    }
    //}
}
