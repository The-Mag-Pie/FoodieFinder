using Android.Service.Autofill;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using FoodieFinder.ViewModels;
using System;

namespace FoodieFinder.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        BindingContext = new ForgotPasswordPageViewModel(serviceProvider);
    }
}