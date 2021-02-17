using Das_Local.Models;
using System.Collections.ObjectModel;

namespace Das_Local.ViewModels
{
    class ContractorsViewModel : BaseViewModel
    {
       
        public ContractorsViewModel()
        {
            contractors = GetContractors();
            Title = "Partner Contractors";
        }

        private ObservableCollection<Contractors> contractors;
        public ObservableCollection<Contractors> Contractors
        {
            get { return contractors; }
            set 
            { 
                contractors = value;
                OnPropertyChange()
;            }
        }
        private ObservableCollection<Contractors> GetContractors()
        {
            return new ObservableCollection<Contractors>
            {
                new Contractors{Name = "A-1 Mechanical and Maintenance", Address = "410 s. Gordan", City = "Wichita", State = "Kansas", ZipCode = "67216", PhoneNumber = "316-943-0206", WebSite =""},
                new Contractors{Name = "American Mechanical", Address = "1608 E. Hwy 54", City = "Andover", State = "Kansas", ZipCode = "67002", PhoneNumber = "316-2625983", WebSite="http://americanmechanicalinc.net/"},
                new Contractors{Name = "Central Consolidated", Address = "3435 W. Harry ", City = "Wichita", State = "Kansas", ZipCode = "67201", PhoneNumber = "316-945-0797", WebSite ="http://www.centralconsolidated.net/"},
                new Contractors{Name = "Dean Norris", Address = "2929 S. Minneapolis", City = "Wichita", State = "Kansas", ZipCode = "67216", PhoneNumber = "316-687-1978", WebSite = "https://www.deanenorris.com/"},
            };
        }
    }
}
