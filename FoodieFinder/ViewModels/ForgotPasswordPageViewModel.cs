using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.ViewModels
{
    partial class ForgotPasswordPageViewModel : UserAccountViewModel
    {
        public ForgotPasswordPageViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        [RelayCommand]
        private void ResetPassword()
        {
            //TODO: Odzyskiwanie hasła
        }

    }
}
