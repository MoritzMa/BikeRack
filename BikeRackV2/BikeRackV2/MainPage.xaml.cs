using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BikeRackV2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage(string key)
        {
            InitializeComponent();
            lblKey.Text += key.ToString();
        }

        private void btnLock_Clicked(object sender, EventArgs e)
        {
            btnStop.IsEnabled = false;
            btnLock.IsEnabled = false;
            btnUnlock.IsEnabled = true;

        }

        private void btnUnlock_Clicked(object sender, EventArgs e)
        {
            btnStop.IsEnabled = true;
            btnLock.IsEnabled = true;
            btnUnlock.IsEnabled = false;
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
