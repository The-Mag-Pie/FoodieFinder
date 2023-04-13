using FoodieFinder.Database;
using FoodieFinder.UserAccount;
using Microsoft.Extensions.Configuration;

namespace FoodieFinder.Pages
{
    internal class StartNavigationPage : NavigationPage
    {
        public StartNavigationPage(IServiceProvider serviceProvider)
            : base(new StartPage(serviceProvider)) { }
    }
}
