using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class SignInPageViewModel : UserAccountViewModel
    {
        public SignInPageViewModel(AppDbContext appDbContext, UserData userData) : base(appDbContext, userData)
        {

        }

        [RelayCommand]
        private void SignIn()
        {
            //TODO: Logowanie
            var log = new Login(_dbContext);
            if(Email != null && Password != null) {
                if(log.CheckIfInDatabase(Email, Password))
                {
                    //Application.Current.MainPage.DisplayAlert("Error", "Poprawne ok", "Ok");

                    if (log.CreateSession(Email))
                    {
                        var userData = _dbContext.User.Where(u => u.Email == Email).First();
                        _userData.IsGuest = false;
                        _userData.UserId = userData.Id;
                        _userData.UserName = Email;

                        Application.Current.MainPage = new AppShell();

                        Application.Current.MainPage.DisplayAlert("Error", log.GetUserNameSession(), "Ok");
                    }
                    else
                    {
                        Application.Current.MainPage.DisplayAlert("Error", "Session not created", "Ok");
                    }

                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Error", "Incorrect Email or Password", "Ok");
                }

            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Error", "All boxes must be filled", "Ok");
            }
        }

    }
}
