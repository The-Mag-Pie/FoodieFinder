using CommunityToolkit.Maui.Views;

namespace FoodieFinder.Popups;

public partial class SaveSharedRecipePopup : Popup
{
    public SaveSharedRecipePopup(string recipeName)
	{
		InitializeComponent();

		ResultWhenUserTapsOutsideOfPopup = false;

		recipeNameLabel.Text = recipeName;
	}

    private void ButtonYesClicked(object sender, EventArgs e)
    {
        Close(true);
    }

    private void ButtonNoClicked(object sender, EventArgs e)
    {
        Close(false);
    }
}