using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BikeRackV2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectionPage : ContentPage
    {
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void lblGotKey_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GotKey());
        }

        private void ConnectionKey_Clicked(object sender, EventArgs e)
        {
            // Just to make a number - remove later
            Random r = new Random();
            int n = r.Next();

            Navigation.PushAsync(new MainPage(n.ToString()));
        }
    }
}