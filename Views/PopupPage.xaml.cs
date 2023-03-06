using CommunityToolkit.Maui.Views;

namespace GearInsight.Views;

public partial class PopupPage : Popup
{
	public PopupPage(string charName, string realm)
	{
		InitializeComponent();
		showInfo.Text = $"Character {charName} on Realm {realm} was not found. Try Again.";
	}
}