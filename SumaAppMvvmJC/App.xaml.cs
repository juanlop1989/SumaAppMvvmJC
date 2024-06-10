using SumaAppMvvmJC.ViewModels;
using SumaAppMvvmJC.Views;

namespace SumaAppMvvmJC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SumaAppMvvmJC.Views.SumaPage());
        }
    }
}
