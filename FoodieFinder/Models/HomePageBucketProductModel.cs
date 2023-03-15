using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    partial class HomePageBucketProductModel : ObservableObject
    {
        [ObservableProperty]
        private string _productName;

        [ObservableProperty]
        private bool _isChecked;
    }
}
