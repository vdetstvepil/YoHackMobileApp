using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{
    public partial class regStartup : ContentPage
    {
        public regStartup()
        {
            InitializeComponent();
        }
        async void Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new startupHome());
        }
        async void Add(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new addMoreInvestors());
        }
    }
}
