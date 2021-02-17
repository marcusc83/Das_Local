using Das_Local.ViewModels;

namespace Das_Local.Models
{
    class Contractors : BaseViewModel
    {
        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private string address = string.Empty;
        public string Address
        {
            get { return address; }
            set { SetProperty(ref address, value);  }
        }

        private string city = string.Empty;
        public string City
        {
            get { return city; }
            set { SetProperty(ref city, value); }
        }
        private string state = string.Empty;
        public string State
        {
            get { return state; }
            set { SetProperty(ref state, value); }
        }
        private string zipcode = string.Empty;
        public string ZipCode
        {
            get { return zipcode; }
            set { SetProperty(ref zipcode, value); }
        }
        private string phonenumber = string.Empty;
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { SetProperty(ref phonenumber, value); }
        }
        private string website = string.Empty;
        public string WebSite
        {
            get { return website; }
            set { SetProperty(ref website, value); }
        }
    }
}
