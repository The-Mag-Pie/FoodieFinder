using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    public partial class StorageItem : ObservableObject
    {
        [ObservableProperty]
        private string _productName;

        [ObservableProperty]
        private int _quantity;
        
        [ObservableProperty]
        private int _expirationDate;
    }
}
