using System.Windows;
using System.Data;
using System.Data.SqlClient;
using Thesis;
using System.Collections.Generic;

namespace GUI
{
    /// <summary>
    /// Interaction logic for ShowHistory.xaml
    /// </summary>
    public partial class ShowHistory : Window
    {
        public ShowHistory()
        {
            InitializeComponent();
        }

        private void FillDataGrid()
        {           
            CurrencyEntities dbcntx = new CurrencyEntities();
            string cmdString = "";
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
            else if (ALL.IsChecked==true)
            {
                currencyCode = ALL.Name;
            }
          
            using (SqlConnection con = new SqlConnection(dbcntx.Database.Connection.ConnectionString))
            {                
                if (currencyCode == "ALL")
                {
                    cmdString = "SELECT CurrencyCode.CurrencyCode, CurrencyCode.CurrencyName ,CurrencyRate.RateDate,CurrencyRate.SellRate,CurrencyRate.BuyRate FROM CurrencyCode LEFT JOIN CurrencyRate ON CurrencyCode.ID = CurrencyRate.CurrencyCodeID ORDER BY CurrencyRate.RateDate ";
                }
                else
                {
                    cmdString = "SELECT CurrencyCode.CurrencyCode, CurrencyCode.CurrencyName ,CurrencyRate.RateDate,CurrencyRate.SellRate,CurrencyRate.BuyRate FROM CurrencyCode LEFT JOIN CurrencyRate ON CurrencyCode.ID = CurrencyRate.CurrencyCodeID WHERE CurrencyCode.CurrencyCode ='" + currencyCode + "' ORDER BY CurrencyRate.RateDate";
                }
                SqlCommand cmd = new SqlCommand(cmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Currency");
                sda.Fill(dt);
                this.dataGrid.ItemsSource = dt.DefaultView;
            }
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }
    }
}
