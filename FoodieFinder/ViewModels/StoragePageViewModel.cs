using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Maui.Views;
using FoodieFinder.Database;
using FoodieFinder.LocalJsonDatabase;
using FoodieFinder.Models;
using FoodieFinder.Popups;
using FoodieFinder.UserAccount;
using System.Collections.ObjectModel;
using FoodieFinder.Pages;
using FoodieFinder.ViewModels;
using Android.Service.Autofill;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static Android.Content.ClipData;

namespace FoodieFinder.ViewModels
{
	public partial class StoragePageViewModel : BaseViewModel
	{
        public ObservableCollection<StorageItem> StorageItem { get; } = new();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(UserFirstLetter))]
        private string _welcomeUser;
        public string UserFirstLetter => WelcomeUser.First().ToString().ToUpper();

        [ObservableProperty]
        private string _addIngredientName = string.Empty;

        private readonly IServiceProvider _serviceProvider;

        public StoragePageViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            var userData = _serviceProvider.GetRequiredService<UserAccount.UserData>();

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

            foreach (var item in _dbContext.StoreRoom.Where(u => u.User_UserId == userData.UserId)) {
                StorageItem.Add(item);
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

                default: break;
            }
        }
        [RelayCommand]
        private async Task AddStorageItem()
        {
            var popup = new AddStorageItemPopup();
            var result = (StorageItem)await Application.Current.MainPage.ShowPopupAsync(popup);

            _dbContext.StoreRoom.Add(result);
            _dbContext.SaveChanges();
        }
        [RelayCommand]
        private void DeleteStorageItem(StorageItem StorageIt)
        {
            _dbContext.StoreRoom.Remove(StorageIt);
            _dbContext.SaveChanges();
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
        private void LoadUserItems()
        {

        }
    } 
}