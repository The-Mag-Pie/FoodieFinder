using CommunityToolkit.Mvvm.ComponentModel;

namespace FoodieFinder.Models
{
    internal partial class IngredientModel : ObservableObject
    {
        public string IngredientName { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }

        [ObservableProperty]
        public bool _isChecked;
    }
}
