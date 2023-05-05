using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class AddSavedRecipePage : ContentPage
{
    private readonly AddSavedRecipePageViewModel vm;
    public AddSavedRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        vm = new(serviceProvider);
        BindingContext = vm;

    }
}