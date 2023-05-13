using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class OnlineRecipePage : ContentPage
{
    private readonly OnlineRecipePageViewModel vm;

    public OnlineRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        vm = new OnlineRecipePageViewModel(serviceProvider);
        BindingContext = vm;

        Appearing += (s, e) => vm.LoadSavedItems();
    }
    async void OfflineOnline(object sender, ToggledEventArgs e)
    {
        //przejœcie
        await Task.Delay(200);
        Shell.Current.GoToAsync(nameof(SavedRecipePage));
    }
}