using SolarPlanets.Models;
using SolarPlanets.Services;

namespace SolarPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	private const uint AnimationDuration = 800u;
	private List<Planet> myPlanets;

    public PlanetsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstpopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void GridArea_Tapped(object sender, EventArgs e)
	{
		await CloseMenu();
	}

    private async Task CloseMenu()
    {
		//close menu and show again main content
		_ = MainContentGrid.FadeTo(1, AnimationDuration);
		_ = MainContentGrid.ScaleTo(1, AnimationDuration);
		await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }

	async void ProfilePicture_Clicked(object sender, EventArgs e)
	{
		_ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
		await MainContentGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainContentGrid.FadeTo(0.8, AnimationDuration);
	}

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		//await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet);
	}
}