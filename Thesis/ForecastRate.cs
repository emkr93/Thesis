using System.Linq;

namespace Thesis
{
    public class ForecastRate
    {
        Dao dao = new Dao();
        decimal[] avgArray = new decimal[12];

        public decimal getMonthlyAverage(string currencyCode)
        {
            decimal avg = 0;

            using (var dbCntxt = new CurrencyEntities())
            {
                CurrencyRate obj = new CurrencyRate();

                for (int i = 1; i < 12; i++)
                {
                    int ID = dao.dictionary[currencyCode];
                    var currencyRatesList = (dbCntxt.CurrencyRates.Where(x => x.CurrencyCodeID == ID && x.RateDate.Month == i).ToList());
                    avgArray[i - 1] = currencyRatesList.Average(x => x.SellRate);
                }

                for (int i = 0; i < 11; i++)
                {
                    decimal x = avgArray[i];
                    avg += avgArray[i];
                }

            }
            return avg / 11;
        }
    }
}
