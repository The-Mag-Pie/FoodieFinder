using FoodieFinder.ViewModels;
using FoodieFinder.Database;

namespace FoodieFinder.Pages;

public partial class RecipePage : ContentPage, IQueryAttributable
{
    private RecipePageViewModel vm;
    private readonly IServiceProvider _serviceProvider;
    public Recipe recipe { get; set; }
    public RecipePage(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        recipe = query["Recipe"] as Recipe;
        OnPropertyChanged("Recipe");
        vm = new(_serviceProvider, recipe);
        BindingContext = vm;

    }
}