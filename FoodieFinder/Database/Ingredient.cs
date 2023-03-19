using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FoodieFinder.Database
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }

    }

    public class IngredientContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Ingredient> Ingredients { get; set; }
        public IngredientContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MyDatabase"));
        }
    }
}
