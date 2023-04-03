using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class SignInPageViewModel : UserAccountViewModel
    {
        public SignInPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider) { }

        [RelayCommand]
        private void SignIn()
        {
            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            var userData = _serviceProvider.GetRequiredService<UserData>();

            //TODO: Logowanie
            var log = new Login(_serviceProvider);
            if(Email != null && Password != null) {
                if(log.CheckIfInDatabase(Email, Password))
                {
                    //Application.Current.MainPage.DisplayAlert("Error", "Poprawne ok", "Ok");

                    if (log.CreateSession(Email))
                    {
                        var dbUserData = dbContext.User.Where(u => u.Email == Email).First();
                        userData.IsGuest = false;
                        userData.UserId = dbUserData.Id;
                        userData.UserName = Email;

                        Application.Current.MainPage = new AppShell();

                        //Application.Current.MainPage.DisplayAlert("Error", log.GetUserNameSession(), "Ok");
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
