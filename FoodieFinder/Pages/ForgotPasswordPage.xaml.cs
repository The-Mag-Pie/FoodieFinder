using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    private readonly ForgotPasswordPageViewModel vm;
    public ForgotPasswordPage(AppDbContext appDbContext, UserData userData)
    {
        InitializeComponent();
        vm = new(appDbContext, userData);
        BindingContext = vm;
    }
}