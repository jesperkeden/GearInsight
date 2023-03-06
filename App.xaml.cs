using GearInsight.Models;

namespace GearInsight;

public partial class App : Application
{
    public static Character UltimateCharacter { get; set; }

    public App(Character _ultimateCharacter)
    {
        InitializeComponent();        

        UltimateCharacter = _ultimateCharacter;

        MainPage = new AppShell();

    }
    protected override Window CreateWindow(IActivationState activationState)
    {
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
