using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{

    public partial class regInvestor : ContentPage
    {
        public regInvestor()
        {
            InitializeComponent();
        }
        async void Save(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new investorHome());
        }
        async void AddMore(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new addMoreStartups());
        }
    }
}
