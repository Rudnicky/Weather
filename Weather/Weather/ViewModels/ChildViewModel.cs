using Weather.Interfaces;
using Weather.ViewModels.Base;

namespace Weather.ViewModels
{
    public class ChildViewModel : ViewModelBase
    {
        public ChildViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
