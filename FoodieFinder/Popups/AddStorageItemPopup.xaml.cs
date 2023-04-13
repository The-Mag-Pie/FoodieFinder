using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Database;
using System.Collections.ObjectModel;


namespace FoodieFinder.Popups;

public partial class AddStorageItemPopup : Popup
{
	private readonly StorageItem addmodel;

    public AddStorageItemPopup()
	{
		InitializeComponent();
        
        BindingContext = addmodel;

	}

	public void AddItem_Clicked(object sender, EventArgs e) => Close(addmodel);
}