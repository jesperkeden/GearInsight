using GearInsight.Models;

namespace GearInsight;

public partial class App : Application
{
    // Skapar instancen av singleton
    public static Character UltimateCharacter { get; set; }

    public App(Character _ultimateCharacter)
    {
        InitializeComponent();        

        UltimateCharacter = _ultimateCharacter;

        MainPage = new AppShell();

    }
    protected override Window CreateWindow(IActivationState activationState) // Sätter en standard size som inte går att ändra, denna storlek är "optimal" för att dem flesta
    {                                                                       // skärmstorlekar ska fungera.
        var window = base.CreateWindow(activationState);

        const int newWidth = 1680;
        const int newHeight = 1050;

        window.MinimumHeight = newHeight;
        window.MaximumHeight = newHeight;

        window.MinimumWidth = newWidth;
        window.MaximumWidth = newWidth;

        return window;

    }
}
