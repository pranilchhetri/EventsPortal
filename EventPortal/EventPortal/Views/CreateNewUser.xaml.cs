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
		public CreateNewUser ()
		{
			InitializeComponent ();
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
    }
}