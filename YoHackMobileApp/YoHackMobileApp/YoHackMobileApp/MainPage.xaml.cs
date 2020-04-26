using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YoHackMobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Investor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new regInvestor());
        }
        async void Startup(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new regStartup());
        }
        async void  Save(object sender, EventArgs e)
        {
            var temp = isInvestor.IsToggled;
            if(temp == true)
            {
                 Data.invLogin = existingLogin.Text;
                await Navigation.PushAsync(new investorHome());
            }
            else
            {
                Data.startupdLogin = existingLogin.Text;
                await Navigation.PushAsync(new startupHome());
            }
           
            
        }
    }
}
