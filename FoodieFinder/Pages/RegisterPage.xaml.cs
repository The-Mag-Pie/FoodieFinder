using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly RegisterPageViewModel vm;
    public RegisterPage(AppDbContext appDbContext, UserData userData)
    {
        InitializeComponent();
        vm = new(appDbContext, userData);
        BindingContext = vm;
    }
}