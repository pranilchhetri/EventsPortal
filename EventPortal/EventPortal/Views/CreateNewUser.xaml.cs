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
	public partial class CreateNewUser : ContentPage
	{
		public CreateNewUser ()
		{
			InitializeComponent ();
            picker.ItemsSource = AddUserGroup();

		}
        List<string> userGroup = new List<string>();
        public List<string> AddUserGroup()
        {
            userGroup.Add("NFNA");
            userGroup.Add("SFSF");
            userGroup.Add("GERDF");
            userGroup.Add("NFNDFDA");
            userGroup.Add("ERTD");
            userGroup.Add("FDDS");

            return userGroup;
        }
	}
}