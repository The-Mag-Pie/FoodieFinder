using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;


namespace FoodieFinder.Popups;

public partial class AddSavedRecipePopup : Popup
{
	private readonly Ingredient addmodel;
	private readonly List <Ingredient> ingredientmodel;

    public AddSavedRecipePopup()
	{
		InitializeComponent();
        
		addmodel = new Ingredient();
        BindingContext = addmodel;

	}

	private void AddItem_Clicked(object sender, EventArgs e) 
	{
        // TODO: dorobić walidację czy dane nie są puste, jeśli tak to wyświetlić komunikat (przykład niżej), jeśli nie to Close(addmodel)
        //Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        if (addmodel.Name != string.Empty && addmodel.Quantity > 0 && addmodel.Unit != string.Empty) {
            Close(addmodel);
		}
		else
		{
            Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        }
		
    }
}