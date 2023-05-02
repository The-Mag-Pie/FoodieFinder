using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class SavedRecipePage : ContentPage
{
    public SavedRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        BindingContext = new SavedRecipePageViewModel(serviceProvider);

    }
}