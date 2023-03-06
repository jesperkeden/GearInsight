using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;
using GearInsight.ViewModels;
using GearInsight.Views;
namespace GearInsight;

public partial class MainPage : ContentPage
{
    MainPageViewModel viewModel = new MainPageViewModel();

    public MainPage()
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

    private void Play_Clicked(object sender, EventArgs e)
    {
        if (mediaElement.CurrentState == MediaElementState.Stopped ||
            mediaElement.CurrentState == MediaElementState.Paused)
        {
            mediaElement.Play();
        }
        else if (mediaElement.CurrentState == MediaElementState.Playing)
        {
            mediaElement.Pause();
        }

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        mediaElement.Play();
    }

}

