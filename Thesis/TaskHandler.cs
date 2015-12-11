using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

namespace Thesis
{
    public class TaskHandler
    {
        List<Task> databaseTasksList = new List<Task>();
        DateTime presentDate = new DateTime();
        XmlParser xmlParser = new XmlParser();
        HtmlAgilityPack htmlAgilityPack = new HtmlAgilityPack();
        Dao dao = new Dao();
        String[] currencyCodesArray = new string[4];
        public TaskHandler()
        {
            currencyCodesArray = dao.dictionary.Keys.ToArray();
            using (var dbCntxt = new CurrencyEntities())
            {
                databaseTasksList = dbCntxt.Tasks.ToList();
            }
            presentDate = DateTime.Now;
        }

        public void CheckTasks()
        {
            List<CurrencyRate> currencyList = new List<CurrencyRate>();

            foreach (var task in databaseTasksList)
            {
                if (presentDate > task.EndDate)
                {
                    dao.executeQuery("UPDATE Tasks SET IsAccomplished = 1 WHERE ID = " + task.ID.ToString());
                }
                if (task.IsAccomplished == false && task.EndDate >= presentDate)
                {
                    Thread th = new Thread(() =>
                    {
                        lock (xmlParser)
                        {
                            xmlParser.setRates(htmlAgilityPack.downloadHtml(task.StartDate, task.EndDate), currencyCodesArray[task.CCID - 1], true);
                        }
                    });
                    th.Start();

                    using (var dbCntxt = new CurrencyEntities())
                    {
                        currencyList = dbCntxt.CurrencyRates.Where(x => x.CurrencyCodeID == task.CCID && x.RateDate >= task.StartDate && x.RateDate <= task.EndDate).ToList();
                    }
                    //##################################################### DOKOŃCZYC!!
                    foreach (var rate in currencyList)
                    {
                        if (task.BuyRate == true)
                        {
                            if (task.TargetCourse - task.Tolerance <= rate.BuyRate)
                            {
                                if (task.TargetCourse <= rate.BuyRate)
                                {
                                    System.Windows.MessageBox.Show("Your currency rate is ready to perform exchange operation!\n The task is completed successfully!\n TASK ID: " + task.ID.ToString() + "\n CURRENCY: " + currencyCodesArray[task.CCID - 1]);
                                    dao.executeQuery("UPDATE Tasks SET IsAccomplished = 1 WHERE ID = " + task.ID.ToString());
                                    break;
                                }
                                System.Windows.MessageBox.Show("Your currency rate is in tolerance range!\n TASK ID: " + task.ID.ToString() + "\n CURRENCY: " + currencyCodesArray[task.CCID - 1] + "\n BUY RATE: " + rate.BuyRate.ToString() + "\n DATE: " + String.Format("{0:M/d/yyyy}", rate.RateDate));
                            }
                        }
                        else
                        {
                            if (task.SellRate == true)
                            {
                                if (task.TargetCourse - task.Tolerance <= rate.SellRate)
                                {
                                    if (task.TargetCourse <= rate.SellRate)
                                    {
                                        System.Windows.MessageBox.Show("Your currency rate is ready to perform exchange operation!\n The task is completed successfully!\n TASK ID: " + task.ID.ToString() + "\n CURRENCY: " + currencyCodesArray[task.CCID - 1]);
                                        dao.executeQuery("UPDATE Tasks SET IsAccomplished = 1 WHERE ID = " + task.ID.ToString());
                                        break;
                                    }
                                    System.Windows.MessageBox.Show("Your currency rate is in tolerance range!\n TASK ID: " + task.ID.ToString() + "\n CURRENCY: " + currencyCodesArray[task.CCID - 1] + "\n SELL RATE: " + rate.SellRate.ToString() + "\n DATE: " + String.Format("{0:M/d/yyyy}", rate.RateDate));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

