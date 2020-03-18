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
    public partial class GotKey : ContentPage
    {
        public GotKey()
        {
            InitializeComponent();
        }

        private void ConnectionKey_Clicked(object sender, EventArgs e)
        {
            string key = entKey.Text;
            

            Navigation.PushAsync(new MainPage(key));
        }
    }
}