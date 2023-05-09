using FoodieFinder.CustomControls.CustomControlsViewModels;

namespace FoodieFinder.CustomControls;

public partial class UserMenuButton : ContentView
{
	public UserMenuButton(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		BindingContext = new UserMenuButtonViewModel(serviceProvider);
    }
}