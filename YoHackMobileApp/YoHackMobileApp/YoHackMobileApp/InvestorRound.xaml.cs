using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{
    public partial class InvestorRound : ContentPage
    {
        public InvestorRound()
        {
            InitializeComponent();
        }
        async void Back(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
