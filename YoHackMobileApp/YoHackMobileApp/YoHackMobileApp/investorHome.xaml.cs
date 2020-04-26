using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YoHackMobileApp
{
    public class Round
    {
        public string Sum { get; set; }
        public override string ToString()
        {
            return Sum;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class investorHome : TabbedPage
    {
        public IList<Round> rounds { get; private set; }
        public investorHome()
        {
            InitializeComponent();
            rounds = new List<Round>();
            List<SendToDB.info> round = new List<SendToDB.info>();
            round = SendToDB.GtInvestorRounds("SELECT \"login_startup\", " +
                "\"stage\", \"sum_money\", \"conditions\" " +
                $"FROM \"round_ss\" WHERE \"login_investor\" = '{Data.invLogin}';");
            foreach (var i in round) {
                rounds.Add(new Round
                {
                    Sum = i.sum_money + "$"

                }) ;
            BindingContext = this;
        }
            
        }
        async void InvestorRound(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InvestorRound());
        }



    }
}
