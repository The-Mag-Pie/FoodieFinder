using CommunityToolkit.Maui.Views;

namespace FoodieFinder.Popups;

public partial class UserOptionsPopup : Popup
{
	public UserOptionsPopup()
	{
		InitializeComponent();

		ResultWhenUserTapsOutsideOfPopup = "cancel";
	}

	private void Logout_Clicked(object sender, EventArgs e) => Close("logout");
	private void Notification_Clicked(object sender, EventArgs e) => Close("notification");
	private void UserOptions_Clicked(object sender, EventArgs e) => Close("UserOptions");
}