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

    private async void GoBackToMainPage_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}