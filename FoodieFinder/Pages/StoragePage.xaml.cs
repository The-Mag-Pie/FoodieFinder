using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class StoragePage : ContentPage
{
    public StoragePage(IServiceProvider serviceProvider)
	{
		InitializeComponent();
        BindingContext = new StoragePageViewModel(serviceProvider);

    }
}