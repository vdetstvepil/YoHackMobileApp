using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{
    public partial class addMoreStartups : ContentPage
    {
        public addMoreStartups()
        {
            InitializeComponent();
        }
        async void Close(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
