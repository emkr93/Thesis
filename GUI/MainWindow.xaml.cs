using System;
using System.Windows;
using System.Windows.Controls;
using Thesis;
using System.Threading;
using System.IO;

namespace GUI
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dao dao = new Dao();
        XmlParser xmlParser = new XmlParser();
        HtmlAgilityPack htmlAgilityPack = new HtmlAgilityPack();
        StackPanel obj = new StackPanel();

        public MainWindow()
        {
            InitializeComponent();
            comboBox.ItemsSource = dao.dictionary.Keys;
            pbStatus.Visibility = Visibility.Hidden;
        }

        private void RunApp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = beginDate.SelectedDate.Value;
                var y = endDate.SelectedDate.Value;
                var z = comboBox.SelectedItem.ToString();
                Thread th = new Thread(() =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        pbStatus.Visibility = Visibility.Visible;
                    });
                    lock (xmlParser)
                    {
                        xmlParser.setRates(htmlAgilityPack.downloadHtml(x, y), z, false);
                    }
                    Dispatcher.Invoke(() =>
                    {
                        pbStatus.Visibility = Visibility.Hidden;

                    });
                });
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have to fullfil all data!");
            }
        }
        private void History_Click(object sender, RoutedEventArgs e)
        {
            ShowHistory sh = new ShowHistory();
            sh.Show();
        }

        private void ShowCharts_Click(object sender, RoutedEventArgs e)
        {
            Charts obj = new Charts();
            obj.Show();
        }

        private void Tasks_Click(object sender, RoutedEventArgs e)
        {
            Tasks obj = new Tasks();
            obj.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            File.Create(@"C:\Users\mateusz.kurowski\Desktop\Thesis\log.txt").Close();
            LogHandler lh = new LogHandler();
            lh.addLog(@"C:\Users\mateusz.kurowski\Desktop\Thesis\log.txt");
            TaskHandler obj = new TaskHandler();
            obj.CheckTasks();
        }

        private void Forecasting_Click(object sender, RoutedEventArgs e)
        {
            ForecastRate obj = new ForecastRate();
            MessageBox.Show(obj.getMonthlyAverage(comboBox.SelectedItem.ToString()).ToString());
        }
    }
}
