using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UI
{
    public partial class MainPage : ContentPage
    {
        Boolean Isregistred = false;
        //Boolean Isrep = false;
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Login_clicked(object sender, EventArgs e)
        {

            if (Isregistred == false)
            {
                await Navigation.PushAsync(new newuser());

            }
            else
            {
                await Navigation.PushAsync(new user());

            }


        }
    }
}
