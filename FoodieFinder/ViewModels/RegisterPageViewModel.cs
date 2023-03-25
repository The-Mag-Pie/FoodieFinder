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
            isConfirmedPassword = !isConfirmedPassword;
            confirmedEyeIcon = isConfirmedPassword ? "eye_on_icon.svg" : "eye_off_icon.svg";

        }

        [RelayCommand]
        private void Register()
        {
            //TODO Rejestracja
            var reg = new Register(_dbContext);
            if(confirmedPassword != null && Email != null && Password != null) {
                if (reg.CheckIfInDatabase(Email)) {
                    //email istnieje już w bazie
                    Application.Current.MainPage.DisplayAlert("Error", "Email already in use", "Ok");
                }
                else
                {
                    if(confirmedPassword == Password)
                    {
                        reg.AddToDatabase(Email, Password);
                        // TU PRZEJŚCIE DO LOGIN OK OK?
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
