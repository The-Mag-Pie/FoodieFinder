using FoodieFinder.CustomControls.CustomControlsViewModels;

namespace FoodieFinder.CustomControls;

public partial class UserMenuButton : ContentView
{
	public UserMenuButton()
	{
		InitializeComponent();

		BindingContext = new UserMenuButtonViewModel(MauiProgram.ServiceProvider);
    }
}