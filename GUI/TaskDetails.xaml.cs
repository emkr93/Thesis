using System;
using System.Linq;
using System.Windows;
using Thesis;

namespace GUI
{
    /// <summary>
    /// Interaction logic for TaskDetails.xaml
    /// </summary>
    public partial class TaskDetails : Window
    {
        public TaskDetails()
        {
            InitializeComponent();
        }

        public void PrintTask(Thesis.Task obj)
        {
            using (var dbCntxt = new CurrencyEntities())
            {
                ID.Content += "  " + obj.ID.ToString();
                CurrencyCode.Content += "  " + dbCntxt.CurrencyCodes.Where(x => x.ID == obj.CCID).First().CurrencyCode1;
                sellRate.Text = obj.SellRate.ToString();
                buyRate.Text = obj.BuyRate.ToString();
                targetCourse.Text = obj.TargetCourse.ToString();
                startDate.SelectedDate = obj.StartDate;
                endDate.SelectedDate = obj.EndDate;
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure that you want to edit this task?", "Edit task", MessageBoxButton.YesNo))
            {
                using (var dbCntxt = new CurrencyEntities())
                {
                    int id = Int32.Parse(ID.Content.ToString());
                    // pobieramy obiekt po ID z listboxa, edytujemy i zapisujemy zmiany
                    var task = dbCntxt.Tasks.Where(x => x.ID == id).FirstOrDefault();
                    task.StartDate = startDate.SelectedDate.Value;
                    task.EndDate = endDate.SelectedDate.Value;
                    task.SellRate = sellRate.Text == "False" ? false : true;
                    task.BuyRate = buyRate.Text == "False" ? false : true;
                    task.TargetCourse = Decimal.Parse(targetCourse.Text);
                    dbCntxt.SaveChanges();
                }
            }
        }
    }
}
