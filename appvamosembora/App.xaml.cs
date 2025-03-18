using appvamosembora.Models;

namespace appvamosembora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }
    }
}
