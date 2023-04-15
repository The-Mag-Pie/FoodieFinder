using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class RecipePage : ContentPage
{
    private readonly RecipePageViewModel vm;
    public RecipePage(IServiceProvider serviceProvider)
    {
		InitializeComponent();

        vm = new(serviceProvider);
        BindingContext = vm;
    }
}