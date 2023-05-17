using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieFinder.Database
{
    public class OnlineRecipe
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Recipe_API_Id")]
        public string RecipeApiId { get; set; }

        [Column("Recipe_Name")]
        public string RecipeName { get; set; }

        [Column("User_Id")]
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
