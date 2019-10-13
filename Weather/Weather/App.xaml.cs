using System.Threading.Tasks;
using Weather.Interfaces;
using Weather.ViewModels.Base;
using Xamarin.Forms;

namespace Weather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            base.OnStart();

            await InitNavigation();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
