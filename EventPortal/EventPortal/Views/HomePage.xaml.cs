using EventPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventPortal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent ();
           
            newsSource.ItemsSource =AddNews();
            
		}
        public static List<NewsItems> GlobalNewsLists = new List<NewsItems>();
        
        
        public List<NewsItems> AddNews()
        {
            
            for(int i=0; i<5; i++)
            {

                GlobalNewsLists.Add(new NewsItems
                {
                    NewsTitle = "Barca Beats Real",
                    NewsDetails = "FC Barcelona boast the strongest football brand in the world according to the latest report by Brand Finance, the world's leading independent brand valuation and strategy consultancy.",
                    NewsImage = "download.png",
                    NewsPublishedDate = "2030-08-09",
                    NewsPublishedTime = "18:40",
                    NewsGuid = Guid.NewGuid(),
                    NewsAuthor = "Antoine Prasad Jharp",
                    NewsLocation = "Lubhu-35, Lalitpur"
                });
                GlobalNewsLists.Add(new NewsItems
                {
                    NewsTitle = "Robert Mueller",
                    NewsDetails = "Special counsel Robert Mueller will not deliver a report to the attorney general next week, as was previously reported by multiple outlets,Attorney General William Barr was preparing to announce the completion of Mueller's investigation into any links between President Donald Trump and Russia as soon as next week, CNN reported Wednesday.a senior Department of Justice official told NBC News on Friday.",
                    NewsImage = "ddf.png",
                    NewsPublishedDate = "202-08-09",
                    NewsPublishedTime = "14:40",
                    NewsGuid = Guid.NewGuid(),
                    NewsAuthor = "dDallsi Jharp",
                    NewsLocation = "Patan-35, Lalitpur"
                });
                GlobalNewsLists.Add(new NewsItems
                {
                    NewsTitle = "Conservative activist",
                    NewsDetails = "Special counsel Robert Mueller will not deliver a report to the attorney general next week, as was previously reported by multiple outlets,Attorney General William Barr was preparing to announce the completion of Mueller's investigation into any links between President Donald Trump and Russia as soon as next week, CNN reported Wednesday.a senior Department of Justice official told NBC News on Friday.",
                    NewsImage = "news_image.png",
                    NewsPublishedDate = "2030-08-09",
                    NewsPublishedTime = "18:40",
                    NewsGuid = Guid.NewGuid(),
                    NewsAuthor = "Zimbae Prasad Jharp",
                    NewsLocation = "Lubhu-35, Lalitpur"
                }
                );
            }
            return GlobalNewsLists;
        }
        public static Guid SelectedGuid;
        private async void NewsSource_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var newsItem = e.Item as NewsItems;
            SelectedGuid = newsItem.NewsGuid;
            await Navigation.PushAsync(new NewsDetails());
        }
    }
}