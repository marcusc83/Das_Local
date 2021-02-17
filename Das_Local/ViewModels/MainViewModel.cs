using System.Collections.ObjectModel;
using Das_Local.Models;
using Xamarin.Forms;

namespace Das_Local.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Title = "SMART 29";
            images = GetCarouselImages();
            articles = GetCarouselArticles();
        }
        private ObservableCollection<CarouselImages> images;
        public ObservableCollection<CarouselImages> Images
        {
            get { return images; }
            set
            {
                images = value;
                OnPropertyChange();
            }
        }

        private ObservableCollection<CarouselImages> GetCarouselImages()
        {
            return new ObservableCollection<CarouselImages>
            {
                new CarouselImages { ImageUrl= "anglewrappedduct.jpg" },
                new CarouselImages { ImageUrl = "ductrun.jpg" },
                new CarouselImages { ImageUrl = "offset.jpg" },
                new CarouselImages { ImageUrl = "panels.jpg" }
            };
        }

        private ObservableCollection<CarouselArticles> articles;
        public ObservableCollection<CarouselArticles> Articles
        {
            get { return articles; }
            set
            {
                articles = value;
                OnPropertyChange();
            }
        }

        private ObservableCollection<CarouselArticles> GetCarouselArticles()
        {
            return new ObservableCollection<CarouselArticles>
            {
                new CarouselArticles { ArticleTitle= "AFL-CIO Calls for Urgent Passage of Landmark Worker Rights Bill", ArticleTextBody = "Lets go Workers"},
                new CarouselArticles { ArticleTitle = "More workers rights", ArticleTextBody = "yea we need more rights for sure" },
                new CarouselArticles { ArticleTitle = "hoorah", ArticleTextBody = "yea a new union organized at google"},
                new CarouselArticles { ArticleTitle = "Bravo", ArticleTextBody = "whats the deal with these free channels"}
            };
        }
    }
}
