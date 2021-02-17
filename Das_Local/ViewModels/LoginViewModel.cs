using Das_Local.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Das_Local.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command GoToCreateAccountPageCommand { get; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            GoToCreateAccountPageCommand = new Command(OnCreateClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync("//MainPage");
        }
        private async void OnCreateClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(NewAccountPage)}");
        }
    }
}
