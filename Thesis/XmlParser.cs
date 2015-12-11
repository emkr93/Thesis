using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Thesis
{
    public class XmlParser
    {
        HtmlAgilityPack obj = new HtmlAgilityPack();
        List<CurrencyRate> CurrencyRatesList = new List<CurrencyRate>();
        CurrencyRate currencyRate;
        Dao dao = new Dao();
        const string url = "http://www.nbp.pl/kursy/xml/";

        public XDocument downloadXml(string url)
        {
            var xml = XDocument.Load(url);
            return xml;
        }
               
        public void setRates(List<string> listOfFiles,string currencyCode,bool isTaskHandler)
        {                  
            for (int i = 0; i < listOfFiles.Count; i++)
            {
                var dataFromXml = downloadXml(url + listOfFiles[i]).Descendants("pozycja").Where(x => x.Descendants("kod_waluty").FirstOrDefault().Value == currencyCode) // list of rates from one file
                                               .FirstOrDefault()
                                               .Descendants().ToList();

                int year = Int32.Parse("20" + listOfFiles[i][5] + listOfFiles[i][6]);
                int month = Int32.Parse("" + listOfFiles[i][7] + listOfFiles[i][8]);
                int day = Int32.Parse("" + listOfFiles[i][9] + listOfFiles[i][10]);
                DateTime date = new DateTime(year, month, day);
                
                currencyRate = new CurrencyRate(decimal.Parse(dataFromXml[4].Value), decimal.Parse(dataFromXml[3].Value), date, dao.dictionary[dataFromXml[2].Value]);
                CurrencyRatesList.Add(currencyRate);
            }
            dao.mapObjects(CurrencyRatesList,null,isTaskHandler);           
        }
    }
}
