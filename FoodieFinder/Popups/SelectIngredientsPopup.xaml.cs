using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Popups.ViewModels;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Popups;

public partial class SelectIngredientsPopup : Popup
{
    private readonly SelectIngredientsPopupViewModel _viewModel;

    public SelectIngredientsPopup(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        _viewModel = new();
        BindingContext = _viewModel;

        var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
        var userData = serviceProvider.GetRequiredService<UserData>();

        foreach (var item in dbContext.StoreRoom.Where(u => u.User_UserId == userData.UserId))
        {
            _viewModel.Ingredients.Add(item.ProductName);
        }
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        _viewModel.SelectedIngredients = e.CurrentSelection.Cast<string>().ToList();
    }

    private void ButtonSearchClicked(object sender, EventArgs e)
    {
        var selectedIngredients = _viewModel.SelectedIngredients;
         
        if(selectedIngredients.Count > 0)
            Close(_viewModel.SelectedIngredients);
        else
            Toast.Make("Select at least one ingredient!", CommunityToolkit.Maui.Core.ToastDuration.Long).Show();
    }

    private void ButtonCancelClicked(object sender, EventArgs e)
    {
        Close();
    }
}