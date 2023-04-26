using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        BindingContext = new RegisterPageViewModel(serviceProvider);
    }
}