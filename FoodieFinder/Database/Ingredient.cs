using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace FoodieFinder.Database
{
    public class Ingredient
    {
        [Column("IngredientId")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        [Column("Recipe_RecipeId")]
        public int RecipeId { get; set; }

    }

    //public class IngredientContext : DbContext
    //{
    //    private readonly IConfiguration _configuration;
    //    public DbSet<Ingredient> Ingredient { get; set; }
    //    public IngredientContext()
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
