using CommunityToolkit.Maui.Views;
using FoodieFinder.Models;

namespace FoodieFinder.Popups;

public partial class FiltersPopup : Popup
{
	private readonly Filters FilterModel;

    public FiltersPopup(Filters Filtr)
	{
		InitializeComponent();
        FilterModel = new Filters();
        FilterModel = Filtr;
        BindingContext = FilterModel;
    }

    private void ApplyFilters_Clicked(object sender, EventArgs e) 
	{
        Close(FilterModel);
    }

    private void ResetFilters_Clicked(object sender, EventArgs e)
    {
        FilterModel.NoMeat = false;
        FilterModel.MaxIngredients = 0;
        FilterModel.MaxPreparationTime = 0;

        Close(FilterModel);
    }
}