namespace GearInsight.Views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        Task load = LoadingBar.ProgressTo(1, 4000, Easing.Linear);

        await load;
        await Navigation.PopAsync();
        await Shell.Current.GoToAsync(nameof(CharacterPage));

    }

   
}