using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YoHackMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class investorHome : TabbedPage
    {
        public investorHome()
        {
            InitializeComponent();
        }
        async void InvestorRound(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InvestorRound());
        }
        //remove back btn
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
