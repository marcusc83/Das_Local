using Das_Local.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Das_Local.Models
{
    class CarouselImages : BaseViewModel
    {
        private string imageUrl = string.Empty;

        public string ImageUrl
        {
            get { return imageUrl; }
            set { SetProperty(ref imageUrl, value); }
        }
    }
}
