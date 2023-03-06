using GearInsight.Models;
using GearInsight.ViewModels;

namespace GearInsight.Views;

public partial class CharacterPage : ContentPage
{
    CharacterPageViewModel viewModel = new CharacterPageViewModel();

    public CharacterPage()
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        CharacterName.Text = TheCharacter.UltimateCharacter.CharacterName;
    }
}