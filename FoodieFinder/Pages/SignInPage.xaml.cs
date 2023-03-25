using FoodieFinder.ViewModels;
using FoodieFinder.Database;

namespace FoodieFinder.Pages;

public partial class SignInPage : ContentPage
{
    private readonly SignInPageViewModel vm;
	public SignInPage(AppDbContext appDbContext)
    {
        InitializeComponent();
        vm = new(appDbContext);
        BindingContext = vm;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new ForgotPasswordPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Shell.SetTabBarIsVisible(this, false);
    }
}