using System;
using System.Windows.Input;
using Weather.Interfaces;
using Weather.ViewModels.Base;
using Xamarin.Forms;

namespace Weather.ViewModels
{
    public class ChildViewModel : ViewModelBase
    {
        public ICommand TextChangedCommand => new Command((object arg) => TextChanged(arg));

        public ChildViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        private void TextChanged(object arg)
        {
            if (arg is TextChangedEventArgs textChangedArgs)
            {
                var newValue = textChangedArgs.NewTextValue;
                var oldValue = textChangedArgs.OldTextValue;
            }
        }
    }
}
