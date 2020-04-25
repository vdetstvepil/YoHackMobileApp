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
            Navigation.NavigationStack.ToList().Clear();
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
        public void ResetNavigationStack()
        {
            if (Navigation != null && Navigation.NavigationStack.Count() > 0)
            {
                var existingPages = Navigation.NavigationStack.ToList();
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }
            }
        }
    }
}
