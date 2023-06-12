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

        //oldPassword.Focused += OnEntryFocused;
        //oldPassword.Unfocused += OnEntryUnfocused;

        //newPassword.Focused += OnEntryFocused;
        //newPassword.Unfocused += OnEntryUnfocused;

        //confirmedPassword.Focused += OnEntryFocused;
        //confirmedPassword.Unfocused += OnEntryUnfocused;

        //newEmail.Focused += OnEntryFocused;
        //newEmail.Unfocused += OnEntryUnfocused;

        //confirmedEmail.Focused += OnEntryFocused;
        //confirmedEmail.Unfocused += OnEntryUnfocused;

    }

    //private void OnEntryFocused(object sender, FocusEventArgs e)
    //{
    //    userPicture.IsVisible = false;
        
    //}

    //private void OnEntryUnfocused(object sender, FocusEventArgs e)
    //{
    //    userPicture.IsVisible = true;
    //}
}