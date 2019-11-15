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
	public partial class StudentPage : ContentPage
	{
		public StudentPage ()
		{
			InitializeComponent ();
		}
        private async void upvote1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new newuser());
        }
        private async void upvote2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new newuser());
        }
        private async void upvote3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new user());
        }
        private async void seemore1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fullpost());
        }
        private async void seemore2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fullpost());
        }
        private async void seemore3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fullpost());
        }

    }
}
