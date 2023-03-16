using CommunityToolkit.Maui.Core.Primitives;
using GearInsight.ViewModels;
namespace GearInsight;

public partial class MainPage : ContentPage
{
    readonly MainPageViewModel viewModel = new();

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

