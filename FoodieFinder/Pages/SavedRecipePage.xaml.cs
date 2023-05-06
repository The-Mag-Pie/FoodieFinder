using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class SavedRecipePage : ContentPage
{
    private readonly SavedRecipePageViewModel vm;

    public SavedRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        vm = new SavedRecipePageViewModel(serviceProvider);
        BindingContext = vm;

        Appearing += (s, e) => vm.LoadSavedItems();
    }
}