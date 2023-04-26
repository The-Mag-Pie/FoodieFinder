namespace FoodieFinder.Pages
{
    internal class StartNavigationPage : NavigationPage
    {
        public StartNavigationPage(IServiceProvider serviceProvider)
            : base(new StartPage(serviceProvider)) { }
    }
}
