using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        BindingContext = new ForgotPasswordPageViewModel(serviceProvider);
    }
}