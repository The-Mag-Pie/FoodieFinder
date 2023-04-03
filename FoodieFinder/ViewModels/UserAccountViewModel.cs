using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Pages;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class UserAccountViewModel : BaseViewModel
    {
        [ObservableProperty]
        protected string email;

        [ObservableProperty]
        protected string password;

        [ObservableProperty]
        private bool isPassword = true;

        [ObservableProperty]
        string eyeIcon = "eye_on_icon.svg";

        protected readonly IServiceProvider _serviceProvider;

        public UserAccountViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [RelayCommand]
        private void TogglePasswordVisibility()
        {
            IsPassword = !IsPassword; 
            EyeIcon = IsPassword ? "eye_on_icon.svg" : "eye_off_icon.svg";
        }

        [RelayCommand]
        private void GoBack()
        {
            //TODO
            Application.Current.MainPage.Navigation.PopAsync();
        }

        [RelayCommand]
        private void GoToForgotPasswordPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ForgotPasswordPage(_serviceProvider));
        }

    }
}
