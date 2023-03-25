using FoodieFinder.ViewModels;
using FoodieFinder.Database;

namespace FoodieFinder.Pages;

public partial class RegisterPage : ContentPage
{
    private readonly RegisterPageViewModel vm;
    public RegisterPage(AppDbContext appDbContext)
    {
        InitializeComponent();
        vm = new(appDbContext);
        BindingContext = vm;
    }
}