using FoodieFinder.ViewModels;
using System.Collections.ObjectModel;

namespace FoodieFinder.Popups.ViewModels
{
    internal partial class SelectIngredientsPopupViewModel : BaseViewModel
    {
        public ObservableCollection<string> Ingredients { get; } = new();
        public List<string> SelectedIngredients { get; set; } = new();
    }
}
