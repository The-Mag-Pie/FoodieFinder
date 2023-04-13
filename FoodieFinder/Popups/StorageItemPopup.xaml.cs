using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Database;
using System.Collections.ObjectModel;


namespace FoodieFinder.Popups;

public partial class StorageItemPopup : Popup
{
	private readonly StorageItem model;

    public StorageItemPopup(StorageItem StorageIt)
	{
		InitializeComponent();
		model = StorageIt;

		BindingContext = model;

		ResultWhenUserTapsOutsideOfPopup = "cancel";

	}

	private void Ok_Clicked(object sender, EventArgs e) => Close("Ok");
}