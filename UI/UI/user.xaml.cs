using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class user : ContentPage
	{
		public user ()
		{
			InitializeComponent ();
		}
        private async void ok_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }


        }
    }