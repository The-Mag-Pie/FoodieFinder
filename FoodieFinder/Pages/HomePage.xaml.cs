using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomePageViewModel vm;

	public HomePage(AppDbContext appDbContext, UserData userData)
	{
		InitializeComponent();

		vm = new(appDbContext, userData);
		BindingContext = vm;

		Disappearing += (s, e) => vm.OnDisappearing();
	}

    protected override bool OnBackButtonPressed()
    {
		vm.OnDisappearing();
        return base.OnBackButtonPressed();
    }
}