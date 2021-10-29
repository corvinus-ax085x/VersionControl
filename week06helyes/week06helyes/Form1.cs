using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week06helyes.Entities;
using week06helyes.MnbServiceReference;

namespace week06helyes
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            CallService();

        }

        void CallService()
        {

            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
            Console.WriteLine(result);
        }
    }
}