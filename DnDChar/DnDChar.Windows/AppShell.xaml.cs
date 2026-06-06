using DnDChar.Windows.Views;

namespace DnDChar.Windows;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CharacterCreatorPage), typeof(CharacterCreatorPage));
		Routing.RegisterRoute(nameof(CharacterSheetPage), typeof(CharacterSheetPage));
		Routing.RegisterRoute(nameof(DiceRollerPage), typeof(DiceRollerPage));
	}
}
