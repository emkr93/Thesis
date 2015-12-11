using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Thesis
{
    public class Dao
    {
        public Dictionary<string, int> dictionary { get; private set; }
        public Dao()
        {
            dictionary = new Dictionary<string, int>();
            using (var dbCntx = new CurrencyEntities())
            {
                var codes = dbCntx.CurrencyCodes.ToList();

                foreach (var item in codes)
                {
                    dictionary.Add(item.CurrencyCode1, item.ID);
                }
            }
        }

        public void executeQuery(string query)
        {

            using (var dbCntxt = new CurrencyEntities())
            {
                dbCntxt.Database.ExecuteSqlCommand(query);
            }

        }
        // pobieramy liste obektow z bazy LINQ po dacie i zwracamy liste obiektow currency rate

        public List<Thesis.Task> getTasks()
        {
            using (var dbCntx = new CurrencyEntities())
            {
                return dbCntx.Tasks.ToList();
            }

        }

        public List<CurrencyRate> getObjectsFromDBS(string currencyCode, DateTime from, DateTime to)
        {
            List<CurrencyRate> listOfObjectsFromDBS = new List<CurrencyRate>();
            int ID = dictionary[currencyCode];
            using (var dbCntx = new CurrencyEntities())
            {

                listOfObjectsFromDBS = (dbCntx.CurrencyRates.Where(x => x.CurrencyCodeID == ID && x.RateDate >= from && x.RateDate <= to)).ToList();
            }

            return listOfObjectsFromDBS;
        }

        public void mapObjects(List<CurrencyRate> list, Thesis.Task task, bool isTaskHandling)
        {
            if (list != null)
            {
                int counter = 0;
                using (var dbCntx = new CurrencyEntities())
                {
                    foreach (var item in list)
                    {
                        if (dbCntx.CurrencyRates.Any(i => i.RateDate == item.RateDate && i.CurrencyCodeID == item.CurrencyCodeID))
                            counter++;
                        else
                        {
                            try
                            {
                                dbCntx.CurrencyRates.Add(item);
                            }
                            catch (SqlException ex)
                            {

                            }
                        }
                    }
                    dbCntx.SaveChanges();
                    if (counter == 0)
                    {

                    }
                    else if (counter != 0 && isTaskHandling == false)
                    {
                        System.Windows.MessageBox.Show(counter.ToString() + " elements have not been added!");
                    }
                }


            }
            else
            {
                using (var dbCntx = new CurrencyEntities())
                {
                    try
                    {
                        dbCntx.Tasks.Add(task);
                    }
                    catch (SqlException ex)
                    {

                    }
                    dbCntx.SaveChanges();
                }

            }
        }

    }

}


