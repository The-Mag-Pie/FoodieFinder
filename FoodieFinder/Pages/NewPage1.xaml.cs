using FoodieFinder.ViewModels;

namespace FoodieFinder.Pages;

public partial class NewPage1 : ContentPage
{
	private SampleViewModel vm;

	public NewPage1()
	{
		InitializeComponent();

		vm = new();
		BindingContext = vm;

		vm.SampleParam1 = "Przykład 1";
		vm.SampleParam2 = "Przykład 2";
	}
}