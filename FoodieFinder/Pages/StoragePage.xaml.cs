using FoodieFinder.Database;
using FoodieFinder.ViewModels;
using FoodieFinder.UserAccount;

namespace FoodieFinder.Pages;

public partial class StoragePage : ContentPage
{
    public StoragePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        BindingContext = new StoragePageViewModel(serviceProvider);

    }
}