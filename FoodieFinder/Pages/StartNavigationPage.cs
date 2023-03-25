using FoodieFinder.Database;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages
{
    internal class StartNavigationPage : NavigationPage
    {
        public StartNavigationPage(AppDbContext dbContext, UserData userData)
            : base(new StartPage(dbContext, userData)) { }
    }
}
