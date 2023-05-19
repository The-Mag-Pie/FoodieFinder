using CommunityToolkit.Maui.Views;
using FoodieFinder.Popups.ViewModels;

namespace FoodieFinder.Popups;

public partial class SelectIngredientsPopup : Popup
{
    private readonly SelectIngredientsPopupViewModel _viewModel;

    public SelectIngredientsPopup()
	{
		InitializeComponent();

        _viewModel = new();
        BindingContext = _viewModel;

        _viewModel.Ingredients.Add("abc");
        _viewModel.Ingredients.Add("def");
        _viewModel.Ingredients.Add("ghi");
    }

    private void ButtonSearchClicked(object sender, EventArgs e)
    {
        Close(_viewModel.SelectedIngredients?.ToList());
    }

    private void ButtonCancelClicked(object sender, EventArgs e)
    {
        Close();
    }
}