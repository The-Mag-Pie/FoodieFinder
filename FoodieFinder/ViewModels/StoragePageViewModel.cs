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

        private readonly AppDbContext _dbContext;
        private readonly UserAccount.UserData _userData;

        public StoragePageViewModel(AppDbContext appDbContext, UserAccount.UserData userData)
        {
            _dbContext = appDbContext;
            _userData = userData;
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
        }
            [RelayCommand]
        private async Task UserOptionsTapped()
        {
            var popup = new UserOptionsPopup();
            var result = (string)await Application.Current.MainPage.ShowPopupAsync(popup);

            switch (result)
            {
                case "logout":
                    var log = new Login(_dbContext);
                    log.DestroySession();
                    Application.Current.MainPage = new StartNavigationPage(_dbContext, _userData);
                    break;

                default: break;
            }
        }
        [RelayCommand]
        private void AddStorageItem()
        {
            
        }
    } 
}