using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;


namespace FoodieFinder.Popups;

public partial class AddStorageItemPopup : Popup
{
	private readonly StorageItem addmodel;

    public AddStorageItemPopup()
	{
		InitializeComponent();
        
		addmodel = new StorageItem();

        BindingContext = addmodel;



    }
    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        addmodel.ExpirationDate = DateOnly.FromDateTime(e.NewDate);
    }

    private void AddItem_Clicked(object sender, EventArgs e) 
	{
        // TODO: dorobić walidację czy dane nie są puste, jeśli tak to wyświetlić komunikat (przykład niżej), jeśli nie to Close(addmodel)
        //Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        string a = addmodel.ExpirationDate.ToString();
        if (addmodel.ProductName != string.Empty && addmodel.Unit != string.Empty && addmodel.Quantity > 0) {
            Close(addmodel);
		}
		else
		{
            Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        }
		
    }

    private void QuantityEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
		// Because initial value in entry is "0", so placeholder is not displayed
		if (quantityEntry.Text == "0")
		{
			quantityEntry.Text = string.Empty;
		}
    }
}