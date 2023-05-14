using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Models;
using FoodieFinder.Notification;
using FoodieFinder.Pages;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using FoodieFinder.ViewModels;

namespace FoodieFinder.CustomControls.CustomControlsViewModels
{
    internal partial class UserMenuButtonViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userFirstLetter;

        private readonly IServiceProvider _serviceProvider;

        public UserMenuButtonViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            var userData = _serviceProvider.GetRequiredService<UserData>();
            UserFirstLetter = userData.UserName.First().ToString().ToUpper();
        }

        [RelayCommand]
        private async Task ButtonTapped()
        {
            var popup = new UserOptionsPopup();
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {
                case "logout":
                    Logout();
                    break;
                case "notification":
                    await NotificationPopupSet();
                    break;
                case "UserOptions":
                    Shell.Current.GoToAsync(nameof(UserAccountPage));
                    break;
                default: break;
            }
        }

        private void Logout()
        {
            var log = new Login(_serviceProvider);
            log.DestroySession();
            Application.Current.MainPage = new StartNavigationPage(_serviceProvider);
        }

        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as SetTimer;
            if (result is null) return;
            // zmienna z czasem znajduje się pod result.SetTime
            var not = new AndroidNotification();
            if (!not.CreateNotification(result.Hour, result.Minutes, result.Seconds))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Notification has not been established!", "OK");
            }
        }
    }
}
