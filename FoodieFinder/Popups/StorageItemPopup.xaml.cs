using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Database;
using System.Collections.ObjectModel;


namespace FoodieFinder.Popups;

public partial class StorageItemPopup : Popup
{
	[ObservableProperty]
    private string _productName = string.Empty;
	[ObservableProperty]
    private int _count = 0;
	[ObservableProperty]
    private string _expirationDate = string.Empty;
    public StorageItemPopup(StorageItem StorageIt)
	{
		InitializeComponent();
		ProductName = StorageIt.ProductName.ToUpper();
		Count = StorageIt.Count;
		ExpirationDate = StorageIt.ExpirationDate.ToString();

		ResultWhenUserTapsOutsideOfPopup = "cancel";

	}

	private void Ok_Clicked(object sender, EventArgs e) => Close("Ok");
}