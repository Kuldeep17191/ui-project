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
	public partial class newuser : ContentPage
	{
        Boolean Isrep = false;
        public newuser ()
		{
			InitializeComponent ();
		}
        private async void ok_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You are Now Registered", "OK");

            if (Isrep == false)
            {
                await Navigation.PushAsync(new user());

            }

        }

    }
}