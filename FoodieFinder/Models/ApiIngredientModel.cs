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

        public string IngredientPrettyString
        {
            get
            {
                var str = string.Empty;
                if (Quantity is not null)
                {
                    str = Quantity + " ";
                    if (Unit is not null)
                        str += Unit + " of ";
                }
                str += IngredientName;
                return str;
            }
        }
    }
}
