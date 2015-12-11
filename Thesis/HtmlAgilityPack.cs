using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Thesis
{
    public class HtmlAgilityPack
    {
       public List<string> listOfFiles { get; set; }
        HtmlWeb getHtmlWeb = new HtmlWeb();
        public List<string> downloadHtml(DateTime begin, DateTime end)
        {
            listOfFiles = new List<string>();
            var document = getHtmlWeb.Load(@"http://www.nbp.pl/kursy/xml/dir.aspx?tt=C");
            var startDate = Int32.Parse(begin.ToString("yyMMdd"));
            var endDate = Int32.Parse(end.ToString("yyMMdd"));
            var aTags = document.DocumentNode.SelectNodes("//a").ToList(); // file names
            aTags.RemoveAt(aTags.Count - 1);
            for (int i = 0; i < aTags.Count; i++)
            {
                if (Int32.Parse(aTags[i].Attributes["href"].Value.Substring(5, 6)) <= endDate && Int32.Parse(aTags[i].Attributes["href"].Value.Substring(5, 6)) >= startDate)
                {
                    listOfFiles.Add(aTags[i].Attributes["href"].Value);
                }
            }                   
            return listOfFiles;
        }

    }
}
