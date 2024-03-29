using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class SearchPage : ContentPage
{
	private readonly SearchPageViewModel vm;

	public SearchPage(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		vm = new SearchPageViewModel(serviceProvider);
		BindingContext = vm;

	}
}