using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FoodieFinder.Pages;

public partial class ModifySavedRecipePage : ContentPage, IQueryAttributable
{
    private ModifySavedRecipePageViewModel vm;
    private readonly IServiceProvider _serviceProvider;
    public Recipe recipe { get; set; }
    public ModifySavedRecipePage(IServiceProvider serviceProvider)
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