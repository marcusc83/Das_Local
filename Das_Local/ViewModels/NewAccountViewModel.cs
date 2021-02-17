using Das_Local.Views;
using Xamarin.Forms;

namespace Das_Local.ViewModels
{
    public class NewAccountViewModel : BaseViewModel
    {
        public Command CreateAccountCommand { get; }

        public NewAccountViewModel()
        {
            Title = "Memeber Info";
            CreateAccountCommand = new Command(OnCreateAccountClicked);
        }

        private async void OnCreateAccountClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
