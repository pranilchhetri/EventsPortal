using EventPortal.Data;
using EventPortal.Models;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventPortal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateNewEvent : ContentPage
	{
        RestServices restServices;
		public CreateNewEvent ()
		{
			InitializeComponent ();
            restServices = new RestServices();
            organizer.ItemsSource = AddUserGroup();
        }
        ObservableCollection<string> userGroup = new ObservableCollection<string>();
        public ObservableCollection<string> AddUserGroup()
        {
            userGroup.Add("NFNA");
            userGroup.Add("SFSF");
            userGroup.Add("GERDF");
            userGroup.Add("NFNDFDA");
            userGroup.Add("ERTD");
            userGroup.Add("FDDS");

            return userGroup;
        }

        private async void Create_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Helpers.Settings.LoginUser))
            {
                Event events = new Event();
                events.Title = lblEventName.Text;
                events.Body = lblEventDetails.Text;
                events.Author = userGroup[organizer.SelectedIndex];
                events.Location = lblLocation.Text;
                events.Published = lblDate.Date + lblTime.Time;
                events.ImageSource = "https://www.oldmissioncapital.com/wp-content/uploads/icon-people.png";

                bool x = await restServices.SaveItemAsync(events, true);
                if (x)
                {
                    lblEventName.Text = "";
                    lblEventDetails.Text = "";
                    lblLocation.Text = "";
                    Console.WriteLine("EventPortal : successfully upload data..");
                    PopupSingle p = new PopupSingle();
                    await Navigation.PushPopupAsync(p);

                }
                else
                {
                    Console.WriteLine("EventPortal : Error occured uploading data..");
                }
            }
            else
            {
                UnableCreateEvent p = new UnableCreateEvent();
                await Navigation.PushPopupAsync(p);
            }

        }
    }
}