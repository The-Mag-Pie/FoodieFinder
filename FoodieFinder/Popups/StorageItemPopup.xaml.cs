using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;


namespace FoodieFinder.Popups;

public partial class StorageItemPopup : Popup
{
	private readonly StorageItem model;

    public StorageItemPopup(StorageItem StorageIt)
	{
		InitializeComponent();
		model = StorageIt;
		model.ProductName = model.ProductName.ToUpper();
		BindingContext = model;

		ResultWhenUserTapsOutsideOfPopup = "cancel";

	}

	private void Ok_Clicked(object sender, EventArgs e) => Close("Ok");
}