using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.Models;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using FoodieFinder.Pages;
using FoodieFinder.Notification;

namespace FoodieFinder.ViewModels
{
    public partial class StoragePageViewModel : BaseViewModel
	{
        public ObservableCollection<StorageItem> StorageItems { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;
        private readonly AppDbContext _dbContext;
        private readonly UserAccount.UserData _userData;

        public StoragePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _userData = _serviceProvider.GetRequiredService<UserAccount.UserData>();
            _dbContext = _serviceProvider.GetRequiredService<AppDbContext>();

            var username = _userData.UserName;
            var atIdx = username.LastIndexOf('@');
            if (atIdx > -1)
            {
                WelcomeUser = username[..atIdx];
            }
            else
            {
                WelcomeUser = username;
            }

            LoadStorageItems();
        }

        private void LoadStorageItems()
        {
            StorageItems.Clear();

            foreach (var item in _dbContext.StoreRoom.Where(u => u.User_UserId == _userData.UserId))
            {
                StorageItems.Add(item);
            }
        }

        [RelayCommand]
        private async Task UserOptionsTapped()
        {
            var popup = new UserOptionsPopup();
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {
                case "logout":
                    var log = new Login(_serviceProvider);
                    log.DestroySession();
                    Application.Current.MainPage = new StartNavigationPage(_serviceProvider);
                    break;
                case "notification":
                    NotificationPopupSet();
                    
                    break;
                default: break;

            }
        }
        [RelayCommand]
        private async Task AddStorageItem()
        {
            var popup = new AddStorageItemPopup();
            var result = await Application.Current.MainPage.ShowPopupAsync(popup) as StorageItem;
            var userData = _serviceProvider.GetRequiredService<UserAccount.UserData>();
            
            if (result != null 
                && (result.ProductName != string.Empty || result.ProductName != "") 
                && result.Quantity > 0
                && (result.Unit != string.Empty || result.Unit != "")) {
                result.User_UserId = userData.UserId;
                _dbContext.StoreRoom.Add(result);
                _dbContext.SaveChanges();

                LoadStorageItems();
            }
            
        }
        [RelayCommand]
        private void DeleteStorageItem(StorageItem StorageIt)
        {
            _dbContext.StoreRoom.Remove(StorageIt);
            _dbContext.SaveChanges();

            LoadStorageItems();
        }
        [RelayCommand]
        private async Task StorageProductTapped(StorageItem StorageIt)
        {
            var popup = new StorageItemPopup(StorageIt);
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {

                default: break;
            }
        }
        private async Task NotificationPopupSet()
        {
            var popup = new SetNotificationPopup();
            var result = (SetTimer)await Application.Current.MainPage.ShowPopupAsync(popup);
            // zmienna z czasem znajduje siê pod result.SetTime
            var not = new AndroidNotification();
            if (!not.CreateNotification(result.Hour, result.Minutes, result.Seconds))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Notification has not been established!", "OK");
            }


        }
    } 
}