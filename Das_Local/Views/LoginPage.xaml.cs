using Das_Local.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Das_Local.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}