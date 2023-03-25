using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class ForgotPasswordPageViewModel : UserAccountViewModel
    {
        public ForgotPasswordPageViewModel(AppDbContext appDbContext, UserData userData) : base(appDbContext, userData)
        {

        }

        [RelayCommand]
        private void ResetPassword()
        {
            //TODO: Odzyskiwanie hasła
        }

    }
}
