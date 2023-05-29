using CommunityToolkit.Maui.Views;
using FoodieFinder.Models;


namespace FoodieFinder.Popups;

public partial class FiltersPopup : Popup
{
	private readonly Filters addmodel;

    public FiltersPopup()
	{
		InitializeComponent();
        
		addmodel = new Filters();

        BindingContext = addmodel;



    }


    private void ApplyFilters_Clicked(object sender, EventArgs e) 
	{

        if (true)
        {
            Close(addmodel);
        }
        else
        {
            Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        }
		
    }

    
}