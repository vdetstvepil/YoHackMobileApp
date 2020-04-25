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
            SendToDB.sendToDB("INSERT INTO \"startup\" " +
                "(\"login_startup\", \"pass\", \"name_startup\", " +
                "description_startup, stage_startup) " +
                $"VALUES ('{login.Text}', '{pass.Text}', '{name.Text}', '{description.Text}','{stage.SelectedItem}');");

            SendToDB.sendToDB("INSERT INTO startup_tags" +
                "(\"login_startup\", \"tag_text\") " +
                $"VALUES ('{login.Text}', '{tag.SelectedItem}');");
            await Navigation.PushAsync(new startupHome());
        }
        async void Add(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new addMoreInvestors());
        }
    }
}
