using FoodieFinder.SuggesticAPI.Models;
using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class OnlineRecipeDetailsPage : ContentPage, IQueryAttributable
{
    private readonly IServiceProvider _serviceProvider;

    public OnlineRecipeDetailsPage(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var recipe = query["Recipe"] as Recipe;
        BindingContext = new OnlineRecipeDetailsPageViewModel(_serviceProvider, recipe);
    }
}