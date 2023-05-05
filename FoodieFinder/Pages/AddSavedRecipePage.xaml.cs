using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class AddSavedRecipePage : ContentPage
{
    public AddSavedRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        BindingContext = new SavedRecipePageViewModel(serviceProvider);

    }
}