using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    private readonly ForgotPasswordPageViewModel vm;
    public ForgotPasswordPage()
    {
        InitializeComponent();
        vm = new();
        BindingContext = vm;
    }
}