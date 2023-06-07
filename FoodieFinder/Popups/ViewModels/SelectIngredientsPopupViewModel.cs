using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.ViewModels;
using System.Collections.ObjectModel;

namespace FoodieFinder.Popups.ViewModels
{
    internal partial class SelectIngredientsPopupViewModel : BaseViewModel
    {
        public ObservableCollection<string> Ingredients { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsSearchButtonEnabled))]
        private List<string> _selectedIngredients = new();

        public bool IsSearchButtonEnabled => SelectedIngredients.Any();
    }
}
