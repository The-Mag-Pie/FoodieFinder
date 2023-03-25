using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FoodieFinder.Database;

namespace FoodieFinder.ViewModels
{
    partial class SignInPageViewModel : UserAccountViewModel
    {
        public SignInPageViewModel(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        [RelayCommand]
        private void SignIn()
        {
            //TODO: Logowanie
        }

    }
}
