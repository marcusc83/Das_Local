using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Das_Local.ViewModels
{
    class ContractViewModel : BaseViewModel
    {
        public ContractViewModel()
        {
            Title = "SMART 29 Contracts";
            btnContract = new Command(loadContract);
            btnMemo = new Command(loadMemo);
        }

        public ICommand btnContract { get; }

        async void loadContract()
        {
            await Browser.OpenAsync("http://sheetmetal29.com/docs/contracts/CONTRACT_5_1_16_Revision_7_1_16_MoKan_Increase.doc",
                                    BrowserLaunchMode.SystemPreferred);
        }

        public ICommand btnMemo { get; }
        async void loadMemo()
        {
            await Browser.OpenAsync("http://sheetmetal29.com/docs/contracts/Memorandum___FINAL.doc",
                                    BrowserLaunchMode.SystemPreferred);
        }
    }
}
