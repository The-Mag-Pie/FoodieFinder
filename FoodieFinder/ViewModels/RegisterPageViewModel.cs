using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Pages;
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

        private AppDbContext _dbContext;
        private UserData _userData;
        public RegisterPageViewModel(AppDbContext appDbContext, UserData userData) : base(appDbContext, userData)
        {
            _dbContext = appDbContext;
            _userData = userData;
        }

        [RelayCommand]
        private void ToggleConfirmedPasswordVisibility()
        {
            IsConfirmedPassword = !IsConfirmedPassword;
            ConfirmedEyeIcon = IsConfirmedPassword ? "eye_on_icon.svg" : "eye_off_icon.svg";

        }

        [RelayCommand]
        private async Task Register()
        {
            //TODO Rejestracja
            var reg = new Register(_dbContext);
            if(ConfirmedPassword != null && Email != null && Password != null) {
                if (reg.CheckIfInDatabase(Email)) {
                    //email istnieje już w bazie
                    Application.Current.MainPage.DisplayAlert("Error", "Email already in use", "Ok");
                }
                else
                {
                    if(ConfirmedPassword == Password)
                    {
                        reg.AddToDatabase(Email, Password);

                        await Application.Current.MainPage.DisplayAlert("Registration", "User registered successfully", "OK");

                        var currentPage = Application.Current.MainPage.Navigation.NavigationStack.Last();
                        Application.Current.MainPage.Navigation.InsertPageBefore(new SignInPage(_dbContext, _userData), currentPage);
                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Passwords must match", "Ok");
                    } 
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "All boxes must be filled", "Ok");
            }
    }

    }
}
