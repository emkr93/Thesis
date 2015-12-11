using System;
using System.Windows;
using Thesis;

namespace GUI
{
    /// <summary>
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        Dao dao = new Dao();
        Thesis.Task task = new Thesis.Task();
        public AddTask()
        {
            InitializeComponent();
            comboBox.ItemsSource = dao.dictionary.Keys;
        }

        private void addTask_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure that you want to set up this task?", "Adding new task", MessageBoxButton.YesNo))
            {
                bool isSellRate = false;
                bool isBuyRate = false; ;
                if (sellRate.IsChecked.Value)
                {
                    isSellRate = true;
                }
                else
                {
                    isBuyRate = true;
                }
                dao.mapObjects(null, new Task(startDate.SelectedDate.Value, EndDate.SelectedDate.Value, dao.dictionary[comboBox.SelectedItem.ToString()], false, Decimal.Parse(targetCourse.Text), isSellRate, isBuyRate, Decimal.Parse((slider.Value / 100).ToString())), false);
                MessageBox.Show("Task successfully added!");
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ToleranceValue.Content = (slider.Value / 100).ToString();
        }
    }
}
