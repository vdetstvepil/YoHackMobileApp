using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
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
            SendToDB.sendToDB("INSERT INTO \"investor_tags\"" +
                $"(\"login_investor\", \"tag_text\") VALUES ('{login.Text}', '{tag.SelectedItem}');");


            SendToDB.sendToDB("INSERT INTO \"investor\" " +
                        "(\"login_investor\", \"pass\", \"name_investor\", \"surname_investor\")" +
                        $"VALUES ('{name.Text}', '{surname.Text}', '{login.Text}', '{pass.Text}');");

            SendToDB.sendToDB("INSERT INTO \"investor_stages\" " +
                "(\"login_investor\", \"stage_text\")" +
                $"VALUES ('{login.Text}', '{stage.SelectedItem}');");

            await Navigation.PushAsync(new investorHome());
        }
        async void AddMore(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new addMoreStartups());
        }
     
    }
}
