using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/// <summary>
/// The purpose of this wrapping is for ease of styling the NavigationPage instance
/// inside the XAML file for the class
/// </summary>
namespace Weather.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationView : NavigationPage
    {
        public NavigationView() : base()
        {
            InitializeComponent();
        }

        public NavigationView(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}