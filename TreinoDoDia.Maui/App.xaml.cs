using TreinoDoDia.Maui.Pages;

namespace TreinoDoDia.Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
