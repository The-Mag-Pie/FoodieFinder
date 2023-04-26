using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class UserAccountPage : ContentPage
{
    private readonly UserAccountPageViewModel vm;
    public UserAccountPage(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        vm = new(serviceProvider);
        BindingContext = vm;
    }
}