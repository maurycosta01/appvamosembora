using appvamosembora.Views;

namespace appvamosembora
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNameClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                await Navigation.PushAsync(new OptionSelect());
            }
        }
    }

}
