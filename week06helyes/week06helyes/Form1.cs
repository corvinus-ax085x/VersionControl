using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using week06helyes.Entities;
using week06helyes.MnbServiceReference;

namespace week06helyes
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        
        
        public Form1()
        {
            InitializeComponent();

           
            EuroCurrency2020();
            //var mnbService = new MNBArfolyamServiceSoapClient();
            //var request = new GetCurrenciesRequestBody();
            //var response = mnbService.GetCurrencies(request);
            //var result = response.GetCurrenciesResult;
            dataGridView1.DataSource = Rates;
            
        }



        private string EuroCurrency2020()
        {
           
                var mnbService = new MNBArfolyamServiceSoapClient();
                var request = new GetExchangeRatesRequestBody
                {
                    currencyNames = "EUR",
                    startDate = "2020-01-01",
                    endDate = "2020-06-30"
                };
                var response = mnbService.GetExchangeRates(request);
                var result = response.GetExchangeRatesResult;
                return result;
            

        }
    }
}
