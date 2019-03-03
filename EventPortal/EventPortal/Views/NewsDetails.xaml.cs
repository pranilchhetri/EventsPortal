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
            var item = MainPage.Results.Find(x => x.Id == HomePage.SelectedId);
            //contentPageTitle.Title = item.NewsTitle.Substring(24) + "...";
            title.Title = item.Title;
            titleImg.Source = item.ImageSource;
            titleLabel.Text = item.Title;
            ReporterLabel.Text = item.Author;
            locationLabel.Text = item.Location;
            DateLabel.Text = item.Published.ToLongDateString();
            TimeLabel.Text = item.Published.ToLongTimeString();
            DetailsLabel.Text = item.Body;
            //foreach(HomePage.SelectedGuid in a.NewsItems)
        }
	}
}