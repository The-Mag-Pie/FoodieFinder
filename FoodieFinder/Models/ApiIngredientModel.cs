using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    internal partial class ApiIngredientModel : ObservableObject
    {
        public string IngredientName { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }

        [ObservableProperty]
        public bool _isChecked;
    }
}
