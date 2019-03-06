using EventPortal.Data;
using EventPortal.Models;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventPortal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        private string username;
        private string password;
        RestServices restServices;
		public Login ()
		{
			InitializeComponent ();
            restServices = new RestServices();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateNewUser(), false);
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            username = lblUsername.Text;
            password = lblPassword.Text;

            var fetchUrl = Constants.FetchSingleUserUrl +"'"+username+"'";
            bool x=await restServices.FetchLoginAsync(fetchUrl,password);
            if (x)
            {
                PopSuccessLogin p = new PopSuccessLogin();
                await Navigation.PushPopupAsync(p);
            }
            else
            {
                PopupInvalidLogin p = new PopupInvalidLogin();
                await Navigation.PushPopupAsync(p);
            }

        }
    }
}