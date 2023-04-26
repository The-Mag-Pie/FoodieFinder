using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieFinder.Database
{
    public partial class StorageItem : ObservableObject
    {
        //[ObservableProperty]
        //[Key]
        [Column("ProductId")]
        public int Id {get; set;}
        [ObservableProperty]
        private string _productName;
        [ObservableProperty]
        private DateOnly _expirationDate;
        [ObservableProperty]
        private int _user_UserId;
        [ObservableProperty]
        private int _quantity;
        [ObservableProperty]
        private string _unit;
    }

    //public class StoreRoomContext : DbContext
    //{
    //    private readonly IConfiguration _configuration;
    //    public DbSet<StoreRoom> StoreRoom { get; set; }
    //    public StoreRoomContext()
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
