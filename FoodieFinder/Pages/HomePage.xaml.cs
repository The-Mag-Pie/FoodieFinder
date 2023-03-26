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

		Disappearing += (s, e) => vm.SaveBucketList();
	}

    protected override bool OnBackButtonPressed()
    {
		vm.SaveBucketList();
        return base.OnBackButtonPressed();
    }

    private void AddIngredientTapped(object sender, EventArgs e)
    {
		// Hide soft keyboard after add button clicked
		//addIngredientEntry.Unfocus();

		// Workaround for MAUI bug - soft keyboard is not hiding when entry is unfocused
		addIngredientEntry.IsEnabled = false;
		addIngredientEntry.IsEnabled = true;
	}
}