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

        //Task load = LoadingBar.ProgressTo(1, 8000, Easing.Linear);
        
        //await load;
        //await Navigation.PopAsync();
        //await Shell.Current.GoToAsync(nameof(CharacterPage));

    }

    private async void TestButton_Clicked(object sender, EventArgs e)
    {
        Task test = LoadingBar.ProgressTo(1, 2000, Easing.Linear);
        await test;
        LoadingBar.Progress = 0;
    }
}