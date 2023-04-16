using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using FoodieFinder.Models;


namespace FoodieFinder.Popups;

public partial class SetNotificationPopup : Popup
{
	private readonly SetTimer model;
    private TimePicker TimePicker { get; set; }
    public SetNotificationPopup()
	{
		InitializeComponent();

        model = new SetTimer();
        BindingContext = model;

    }

	private void Set_Clicked(object sender, EventArgs e) 
	{
        // TODO: dorobić walidację czy dane nie są puste, jeśli tak to wyświetlić komunikat (przykład niżej), jeśli nie to Close(addmodel)
        //Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        if (model != null && model.SetTime.ToString() != string.Empty) {
            Application.Current.MainPage.DisplayAlert("Error", model.SetTime.ToString(), "OK");
            Close(model);
		}
		else
		{
            Application.Current.MainPage.DisplayAlert("Error", "You have not provided required data", "OK");
        }
		
    }

}