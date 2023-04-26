using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.Pages;
using FoodieFinder.UserAccount;


namespace FoodieFinder.ViewModels
{
    partial class UserAccountPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        private readonly IServiceProvider _serviceProvider;
        private IEnumerable<User> currentUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();
        [ObservableProperty]
        private string oldPassword;
        [ObservableProperty]
        private string newPassword;
        [ObservableProperty]
        private string confirmedPassword;
        [ObservableProperty]
        private string newEmail;
        [ObservableProperty]
        private string confirmedEmail;
        public UserAccountPageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            var userData = _serviceProvider.GetRequiredService<UserData>();

            var username = userData.UserName;
            var atIdx = username.LastIndexOf('@');
            if (atIdx > -1)
            {
                WelcomeUser = username[..atIdx];
            }
            else
            {
                WelcomeUser = username;
            }

            currentUser = (IEnumerable<User>)dbContext.User.Where(u => u.Id == userData.UserId);

        }

        [RelayCommand]
        private void ChangeEmail()
        {
            if (string.IsNullOrWhiteSpace(NewEmail) || string.IsNullOrWhiteSpace(ConfirmedEmail))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter and confirm your new email", "Ok");
                return;
            }

            if(NewEmail != ConfirmedEmail)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Confirmed email doesn't match your new email", "Ok");
                return;
            }

            var log = new Login(_serviceProvider);

            if (!log.IsEmail(NewEmail))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a valid email", "Ok");
                return;
            }

            currentUser.First().Email = NewEmail;
            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            dbContext.SaveChanges();

            Application.Current.MainPage.DisplayAlert("Success", "Your email has been changed. You will be loged out", "Ok");
            log.DestroySession();
            Application.Current.MainPage = new StartNavigationPage(_serviceProvider);
        }

        [RelayCommand]
        private void ChangePassword()
        {

            if (string.IsNullOrWhiteSpace(OldPassword))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter your old password. In case you don't remember it you can log out and recover it", "Ok");
                return;
            }
            if (string.IsNullOrWhiteSpace(NewPassword) || string.IsNullOrWhiteSpace(ConfirmedPassword))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Please enter and confirm your new password", "Ok");
                return;
            }

            if (NewPassword != ConfirmedPassword)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Confirmed password doesn't match your new password", "Ok");
                return;
            }

            var log = new Login(_serviceProvider);
            var reg = new Register(_serviceProvider);

            string currentHashedPassword = currentUser.First().Password;

            if(!reg.ComparePassword(OldPassword, currentHashedPassword))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Old passwod you entered doesn't match your current password", "Ok");
                return;
            }

            string newHashedPassword = reg.EncryptPassword(NewPassword);

            currentUser.First().Password = newHashedPassword;
            var dbContext = _serviceProvider.GetRequiredService<AppDbContext>();
            dbContext.SaveChanges();

            Application.Current.MainPage.DisplayAlert("Success", "Your password has been changed. You will be loged out", "Ok");
            log.DestroySession();
            Application.Current.MainPage = new StartNavigationPage(_serviceProvider);
        }
    }
}
