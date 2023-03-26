namespace SolarPlanets.Views;

public partial class PlanetsPage : ContentPage
{
	private const uint AnimationDuration = 800u;

    public PlanetsPage()
	{
		InitializeComponent();
	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
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
}