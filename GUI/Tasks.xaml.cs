using System;
using System.Linq;
using System.Windows;
using Thesis;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Tasks.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        public static Tasks instance = new Tasks();
        Dao dao = new Dao();
        string isRunning = "";
        public Tasks()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddTask obj = new AddTask();
            obj.Show();
        }

        public void FullfilListBox()
        {
            foreach (var item in dao.getTasks())
            {
                if (item.IsAccomplished == false)
                {
                    isRunning = "Task is in progress, predicted finish time : " + String.Format("{0:MM/dd/yyyy}", item.EndDate);
                }
                else
                {
                    isRunning = "Task is accomplished";
                }
                listBox.Items.Add("ID: " + item.ID + " " + isRunning);
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            FullfilListBox();
        }
        private void Details_Click(object sender, RoutedEventArgs e)
        {
            using (var dbCntxt = new CurrencyEntities())
            {
                string ID = "";
                ID = Char.ToString(listBox.SelectedItem.ToString()[4]);
                ID += Char.ToString(listBox.SelectedItem.ToString()[5]);
                int id = Int32.Parse(ID);
                TaskDetails obj = new TaskDetails();
                obj.PrintTask((dbCntxt.Tasks.Where(x => x.ID == id).FirstOrDefault()));
                obj.Show();
            }
        }

        private void CancelTask_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("Are you sure that you want to delete this task?\n You will not be able to reverse this operation", "Delete task", MessageBoxButton.YesNo))
            {
                string ID = "";
                ID = Char.ToString(listBox.SelectedItem.ToString()[4]);
                ID += Char.ToString(listBox.SelectedItem.ToString()[5]);
                int id = Int32.Parse(ID);
                using (var dbCntxt = new CurrencyEntities())
                {
                    dbCntxt.Tasks.Remove(dbCntxt.Tasks.Where(x => x.ID == id).FirstOrDefault());
                    dbCntxt.SaveChanges();
                    listBox.Items.Clear();
                }
                FullfilListBox();
            }
        }
    }
}
