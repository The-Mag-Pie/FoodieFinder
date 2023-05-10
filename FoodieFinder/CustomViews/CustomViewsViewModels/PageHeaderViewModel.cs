using CommunityToolkit.Mvvm.ComponentModel;
using FoodieFinder.UserAccount;
using FoodieFinder.ViewModels;

namespace FoodieFinder.CustomViews.CustomViewsViewModels
{
    internal partial class PageHeaderViewModel : BaseViewModel
    {
        private static string _getShortUserName(string username)
        {
            var atIdx = username.LastIndexOf('@');
            if (atIdx > -1)
            {
                return username[..atIdx];
            }
            else
            {
                return username;
            }
        }

        [ObservableProperty]
        private string _userName;

        public PageHeaderViewModel(IServiceProvider serviceProvider)
        {
            var userData = serviceProvider.GetRequiredService<UserData>();
            UserName = _getShortUserName(userData.UserName);
        }
    }
}
