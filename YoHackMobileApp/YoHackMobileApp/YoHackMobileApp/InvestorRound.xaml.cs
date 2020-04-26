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
        async void Create(object sender, EventArgs args)
        {
            SendToDB.sendToDB("INSERT INTO round_ss " +
                "(\"login_investor\", \"stage\", \"sum_money\", \"conditions\") " +
                $"VALUES ('{Data.invLogin}', '{stage.SelectedItem}',{sum.Text}, '{condition.Text}');");
            await Navigation.PopModalAsync();
        }
    }
}
