using Weather.Interfaces;
using Weather.ViewModels.Base;

namespace Weather.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
