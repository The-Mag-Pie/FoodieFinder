using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    public partial class BucketListItem : ObservableObject
    {
        [ObservableProperty]
        private string _productName;

        [ObservableProperty]
        private bool _isChecked;
    }
}
