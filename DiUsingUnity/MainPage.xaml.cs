
using CommonServiceLocator;
using Xamarin.Forms;

namespace DiUsingUnity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(MainViewModel));
        }
    }
}
