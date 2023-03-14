using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomePageViewModel vm;

	public HomePage()
	{
		InitializeComponent();

		vm = new();
		BindingContext = vm;
	}
}