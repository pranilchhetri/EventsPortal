using EventPortal.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EventPortal
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }
        private void Button_Clicked1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new NewsDetails());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new NewsDetails());
            IsPresented = true;
        }

        private async void GoToLogin(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new Login());
            //Detail = new NavigationPage(new Login());

        }
    }
}
