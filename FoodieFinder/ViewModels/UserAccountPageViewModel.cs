using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class UserAccountPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        private readonly IServiceProvider _serviceProvider;
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

        }
    }
}
