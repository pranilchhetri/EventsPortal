using EventPortal.Data;
using EventPortal.Models;
using Rg.Plugins.Popup.Extensions;
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
	public partial class CreateNewUser : ContentPage
	{
        RestServices restServices;
		public CreateNewUser ()
		{
			InitializeComponent ();
            restServices = new RestServices();
            picker.ItemsSource = AddUserGroup();

		}
        public ObservableCollection<string> userGroup = new ObservableCollection<string>();
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
        
        private void CreateGroup_clicked(object sender, EventArgs e)
        {
            newGroup.IsVisible = true;
        }

        private void newGroupEntry_Completed(object sender, EventArgs e)
        {
            
            userGroup.Add(createGroupEntryHere.Text);
            newGroup.IsVisible = false;
        }

        private async void CreateNewUserClicked(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = lblUsername.Text;
            user.Password = lblPassword.Text;
            user.Address = lblAddress.Text;
            user.Email = lblEmail.Text;
            user.Phone = lblPhone.Text;
            user.Usergroup= userGroup[picker.SelectedIndex];

            bool x = await restServices.SaveNewUserAsync(user, true);
            if (x)
            {
                lblUsername.Text = "";
                lblPassword.Text = "";
                lblAddress.Text = "";
                lblPhone.Text = "";
                lblEmail.Text = "";
                lblConfirmPassword.Text = "";
                Console.WriteLine("EventPortal : successfully upload data..");
                PopupSingle p = new PopupSingle();
                await Navigation.PushPopupAsync(p);

            }
            else
            {
                Console.WriteLine("EventPortal : Error occured uploading data..");
            }


        }
    }
}