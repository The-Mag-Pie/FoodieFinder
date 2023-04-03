using FoodieFinder.ViewModels;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        BindingContext = new RegisterPageViewModel(serviceProvider);
    }
}