using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using System;


namespace FoodieFinder.ViewModels
{
    partial class RegisterPageViewModel : UserAccountViewModel
    {
        [ObservableProperty]
        private string confirmedPassword;

        [ObservableProperty]
        private bool isConfirmedPassword = true;

        [ObservableProperty]
        private string confirmedEyeIcon = "eye_on_icon.svg";

        public RegisterPageViewModel(AppDbContext appDbContext, UserData userData) : base(appDbContext, userData)
        {

        }

        [RelayCommand]
        private void ToggleConfirmedPasswordVisibility()
        {
            IsConfirmedPassword = !IsConfirmedPassword;
            ConfirmedEyeIcon = IsConfirmedPassword ? "eye_on_icon.svg" : "eye_off_icon.svg";

        }

        [RelayCommand]
        private void Register()
        {
            //TODO Rejestracja
            var reg = new Register(_dbContext);
            reg.AddToDatabase(Email, Password);
    }

    }
}
