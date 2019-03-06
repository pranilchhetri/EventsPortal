using EventPortal.Data;
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
        RestServices restServices;
        public MainPage()
        {
            InitializeComponent();
            restServices = new RestServices();
            FetchItemFromServer();
        }

        private async void FetchItemFromServer()
        {
            
            bool x = await restServices.FetchItemAsync(Constants.FetchEventsUrl);
            if (x)
            {
                Detail = new NavigationPage(new HomePage());
                IsPresented = false;
            }
        }
        private void Home_Clicked(object sender, EventArgs e)
        {
            FetchItemFromServer();
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
