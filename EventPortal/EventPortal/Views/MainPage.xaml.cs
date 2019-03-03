using EventPortal.Models;
using EventPortal.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventPortal
{
    public partial class MainPage : MasterDetailPage
    {
        HttpClient client;
        public static List<Event> Results = new List<Event>();
        public MainPage()
        {
            InitializeComponent();
            FetchData(Constants.FetchDataUrl);
           
        }
        public async void FetchData(string url)
        {
           
            client = new HttpClient();
            var uri = new Uri(string.Format(url, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Results = JsonConvert.DeserializeObject<List<Event>>(content);
                    //Items = JsonConvert.DeserializeObject<Apple>(content);
                    Detail = new NavigationPage(new HomePage());
                    IsPresented = false;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }
        private void CreateNewEvent(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CreateNewEvent());
            IsPresented = false;
        }
        
        private async void GoToLogin(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new Login());
            //Detail = new NavigationPage(new Login());

        }
    }
}
