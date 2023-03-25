using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class SignInPage : ContentPage
{
    private readonly SignInPageViewModel vm;
	public SignInPage(AppDbContext appDbContext, UserData userData)
    {
        InitializeComponent();
        vm = new(appDbContext, userData);
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