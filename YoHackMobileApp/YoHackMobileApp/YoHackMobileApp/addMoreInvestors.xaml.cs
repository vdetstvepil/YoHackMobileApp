using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{
    public partial class addMoreInvestors : ContentPage
    {
        public addMoreInvestors()
        {
            InitializeComponent();
        }
        async void Close(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
