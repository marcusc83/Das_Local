using Das_Local.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Das_Local.Models
{
    class CarouselArticles : BaseViewModel
    {
        private string articletitle = string.Empty;
        public string ArticleTitle
        {
            get { return articletitle; }
            set { SetProperty(ref articletitle, value); }
        }

        private string articletextbody = string.Empty;
        public string ArticleTextBody
        {
            get { return articletextbody; }
            set { SetProperty(ref articletextbody, value); }
        }

    }
}
