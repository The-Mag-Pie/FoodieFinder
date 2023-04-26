using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieFinder.Database
{
    public class Recipe
    {
        [Column("RecipeId")]
        public int Id { get; set; }

        [Column("RecipeName")]
        public string Name { get; set; }

        [Column("RecipeDescription")]
        public string Description { get; set; }
        public string Preparation { get; set; }

        [Column("User_UserId")]
        public int UserId { get; set; }

    }

    //public class RecipeContext : DbContext
    //{
    //    private readonly IConfiguration _configuration;
    //    public DbSet<Recipe> Recipe { get; set; }
    //    public RecipeContext()
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
