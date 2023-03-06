using GearInsight.Views;
namespace GearInsight;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CharacterPage), typeof(CharacterPage));
	}
}
