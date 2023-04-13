using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    public partial class StorageItemXXXXX : ObservableObject
    {
        [ObservableProperty]
        private int _productId;
        
        [ObservableProperty]
        private string _productName;
        
        [ObservableProperty]
        private string _expirationDate;

        [ObservableProperty]
        private int _quantity;

        [ObservableProperty]
        private int _user_UserId;

        [ObservableProperty]
        private int _unit;
    }
}
