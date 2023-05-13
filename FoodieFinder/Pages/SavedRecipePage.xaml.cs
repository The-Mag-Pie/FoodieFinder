using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class SavedRecipePage : ContentPage
{
    private readonly SavedRecipePageViewModel vm;

    public SavedRecipePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        vm = new SavedRecipePageViewModel(serviceProvider);
        BindingContext = vm;

        Appearing += (s, e) => vm.LoadSavedItems();
    }
    async void OfflineOnline(object sender, ToggledEventArgs e)
    {
        //Application.Current.MainPage.DisplayAlert("Error", "sss", "OK");
        await Task.Delay(200);
        Shell.Current.GoToAsync(nameof(OnlineRecipePage));
    }
}