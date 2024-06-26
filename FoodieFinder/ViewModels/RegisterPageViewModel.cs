﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;
using System.Text.RegularExpressions;

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

        public RegisterPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        [RelayCommand]
        private void ToggleConfirmedPasswordVisibility()
        {
            IsConfirmedPassword = !IsConfirmedPassword;
            ConfirmedEyeIcon = IsConfirmedPassword ? "eye_on_icon.svg" : "eye_off_icon.svg";

        }

        // ...

        [RelayCommand]
        private async Task Register()
        {
            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

            // TODO Rejestracja
            var reg = new Register(_serviceProvider);
            if (ConfirmedPassword != null && reg.IsEmail(email) && Password != null)
            {
                if (reg.CheckIfInDatabase(Email))
                {
                    // email istnieje już w bazie
                    Application.Current.MainPage.DisplayAlert("Error", "Email already in use", "Ok");
                }
                else
                {
                    // Password complexity check using regex
                    string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
                    //string passwordPattern = @"(?=^.{8,}$)(?=.*d)(?=.*[!@#$%^&*]+)(?![.n])(?=.*[A-Z])(?=.*[a-z]).*$";
                    bool isPasswordComplex = Regex.IsMatch(Password, passwordPattern);

                    if (isPasswordComplex)
                    {
                        if (ConfirmedPassword == Password)
                        {
                            reg.AddToDatabase(Email, Password);

                            await Application.Current.MainPage.DisplayAlert("Registration", "User registered successfully", "OK");

                            var currentPage = Application.Current.MainPage.Navigation.NavigationStack.Last();
                            Application.Current.MainPage.Navigation.InsertPageBefore(new SignInPage(_serviceProvider), currentPage);
                            await Application.Current.MainPage.Navigation.PopAsync();
                        }
                        else
                        {
                            Application.Current.MainPage.DisplayAlert("Error", "Passwords must match", "Ok");
                        }
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Password must meet the complexity requirements:\nAt least 1 lowercase letter\nAt least 1 uppercase letter\nAt least 1 digit\nAt least 1 special character\nMinimum 8 characters", "Ok");
                    }
                }
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "All boxes must be filled with valid values", "Ok");
            }
        }

    }
}
