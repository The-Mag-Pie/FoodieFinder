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
        }

    }
}
