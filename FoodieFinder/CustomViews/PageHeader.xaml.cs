using FoodieFinder.CustomViews.CustomViewsViewModels;

namespace FoodieFinder.CustomViews;

public partial class PageHeader : ContentView
{
	public PageHeader()
	{
		InitializeComponent();

		BindingContext = new PageHeaderViewModel(MauiProgram.ServiceProvider);
	}
}