using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
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
            var callservice = CallService();

        }

        string CallService()
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
            return result;
        }

        void XMLProcessing(string result)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData rd = new RateData();
                Rates.Add(rd);
                rd.Date = DateTime.Parse(item.GetAttribute("date"));
                var childElement = (XmlElement)item.ChildNodes[0];
                rd.Currency = childElement.GetAttribute("curr");

                // Érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rd.Value = value / unit;
            }
        }

        void Graph()
        {
            chart1.DataSource = Rates;
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;

            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

    }