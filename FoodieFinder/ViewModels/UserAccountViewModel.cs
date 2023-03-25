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
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private bool isPassword = true;

        [ObservableProperty]
        string eyeIcon = "eye_on_icon.svg";

        private AppDbContext _dbContext;
        private UserData _userData;

        public UserAccountViewModel(AppDbContext appDbContext, UserData userData)
        {
            _dbContext = appDbContext;
            _userData = userData;
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
            Application.Current.MainPage = new StartPage(_dbContext, _userData);
        }

    }
}
