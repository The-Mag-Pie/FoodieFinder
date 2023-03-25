using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
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
                        // SORKU TU PRZEJŚCIE DO GŁÓWNEJ STRONY TAK ZWANY HOME PAGE ok?
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
