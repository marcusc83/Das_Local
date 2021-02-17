using System;
using System.Collections.Generic;

namespace Das_Local.ViewModels
{
    public class PayDuesViewModel : BaseViewModel
    {
        public PayDuesViewModel()
        {
            Title = "Dues Payment";
            months = GetMonths();
            years = GetYears();
        }
        //set months to picker
        private List<string> months;
        public List<string> Months
        {
            get { return months; }
            set
            {
                months = value;
                OnPropertyChange();
            }
        }
        private static List<string> GetMonths()
        {    
            List<string> Months = new List<string>();
            string[] monthArray = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "Decemebr" };
            for(int i = 0; i < monthArray.Length; i++)
            {
                Months.Add(monthArray[i]);
            }

            return Months;
        }
        // end setting months

        //setting years to picker
        private List<string> years;
        public List<string> Years
        {
            get { return years; }
            set
            {
                years = value;
                OnPropertyChange();
            }
        }
        private static List<string> GetYears()
        {
            List<string> list = new List<string>();
            string[] yearArray = { "2021", "2022", "2023", "2024", "2025", "2026" };
            for(int i = 0; i< yearArray.Length; i++)
            {
                list.Add(yearArray[i]);
            }
            return list;
        }
        //end setting years
    }
}
