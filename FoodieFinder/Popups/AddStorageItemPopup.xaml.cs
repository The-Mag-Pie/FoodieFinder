﻿using CommunityToolkit.Maui.Views;
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
        
		addmodel = new StorageItem();
        BindingContext = addmodel;

	}

	private void AddItem_Clicked(object sender, EventArgs e) 
	{
		// TODO: dorobić walidację czy dane nie są puste, jeśli tak to wyświetlić komunikat (przykład niżej), jeśli nie to Close(addmodel)
		//Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
		if(addmodel.ProductName != string.Empty && addmodel.Unit != string.Empty && addmodel.Quantity <= 0) {
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