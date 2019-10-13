using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Weather.Interfaces;
using Weather.ViewModels.Base;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand GoToChildViewButtonClickedCommand => new Command(async () => await GoToChildViewButtonClicked());

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private async Task GoToChildViewButtonClicked()
        {
            await base.NavigationService.NavigateToAsync<ChildViewModel>();
        }
    }
}
