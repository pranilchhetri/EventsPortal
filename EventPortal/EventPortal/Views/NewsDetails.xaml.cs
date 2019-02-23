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
	public partial class NewsDetails : ContentPage
	{
		public NewsDetails()
		{
			InitializeComponent ();
            var item = HomePage.GlobalNewsLists.Find(x => x.NewsGuid == HomePage.SelectedGuid);
            //contentPageTitle.Title = item.NewsTitle.Substring(24) + "...";
            title.Title = item.NewsTitle;
            titleImg.Source = item.NewsImage;
            titleLabel.Text = item.NewsTitle;
            ReporterLabel.Text = item.NewsAuthor;
            locationLabel.Text = item.NewsLocation;
            DateLabel.Text = item.NewsPublishedDate;
            TimeLabel.Text = item.NewsPublishedTime;
            DetailsLabel.Text = item.NewsDetails;
            //foreach(HomePage.SelectedGuid in a.NewsItems)
        }
	}
}