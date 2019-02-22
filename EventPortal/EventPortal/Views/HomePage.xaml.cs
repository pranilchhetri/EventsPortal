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
            newsSource.ItemsSource = AddNews();
		}
        List<NewsItems> newsItems = new List<NewsItems>();
        public List<NewsItems> AddNews()
        {
            for(int i=0; i<10; i++)
            {
                newsItems.Add(new NewsItems
                {
                    NewsTitle = "Barca Beats Real",
                    NewsDetails = "FC Barcelona boast the strongest football brand in the world according to the latest report by Brand Finance, the world's leading independent brand valuation and strategy consultancy.",
                    NewsImage = "download.png",
                    NewsPublishedDate = "2030-08-09",
                    NewsPublishedTime = "18:40"
                }
                    );
            }
            return newsItems;
        }

	}
}