﻿using Rg.Plugins.Popup.Extensions;
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
	public partial class PopSuccessLogin : Rg.Plugins.Popup.Pages.PopupPage
    {
		public PopSuccessLogin ()
		{
			InitializeComponent ();
		}

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}