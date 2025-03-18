namespace appvamosembora.Models;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    // WelcomePage.xaml.cs
    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}