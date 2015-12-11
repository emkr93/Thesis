using System.Windows;
using Thesis;
using System.Collections;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Charts.xaml
    /// </summary>
    public partial class Charts : Window
    {
        Dao dao = new Dao();
        public Charts()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            string currencyCode = "";
            if (EUR.IsChecked == true)
            {
                currencyCode = EUR.Name;
            }

            else if (GBP.IsChecked == true)
            {
                currencyCode = GBP.Name;
            }
            else if (CHF.IsChecked == true)
            {
                currencyCode = CHF.Name;
            }
            else if (USD.IsChecked == true)
            {
                currencyCode = USD.Name;
            }
            var list = dao.getObjectsFromDBS(currencyCode, From.SelectedDate.Value, To.SelectedDate.Value);
            ArrayList a = new ArrayList();
            foreach (var item in list)
            {
                var anonimeObj = new { SellRate = item.SellRate, Date = item.RateDate };
                a.Add(anonimeObj);
            }
            chart.DataContext = a;
        }
    }
}
