using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YoHackMobileApp
{
    public partial class startupHome : ContentPage
    {
        public startupHome()
        {
            InitializeComponent();
        }
        //remove back btn
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
