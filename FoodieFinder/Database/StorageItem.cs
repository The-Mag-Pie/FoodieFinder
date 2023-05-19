using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        [NotifyPropertyChangedFor(nameof(DotColor))]
        private DateOnly _expirationDate;
        [ObservableProperty]
        private int _user_UserId;
        [ObservableProperty]
        private int _quantity;
        [ObservableProperty]
        private string _unit;

        [NotMapped]
        public Color DotColor
        {
            get
            {
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now.Date);

                if (ExpirationDate < currentDate)
                {
                    return Color.FromRgb(255, 0, 0);
                }
                else if (ExpirationDate.Day - currentDate.Day <= 5)
                {
                    return Color.FromRgb(255, 165, 0);
                }
                else
                {
                    return Color.FromRgb(0, 128, 0);
                }
            }
        }
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
