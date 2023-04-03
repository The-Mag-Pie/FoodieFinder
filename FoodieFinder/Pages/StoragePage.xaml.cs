using FoodieFinder.Database;
using FoodieFinder.ViewModels;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class StoragePage : ContentPage
{
    private readonly StoragePageViewModel vm;

    public StoragePage(AppDbContext appDbContext, UserData userData)
	{
		InitializeComponent();
        vm = new(appDbContext, userData);
        BindingContext = vm;

    }
}