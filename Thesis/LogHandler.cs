using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesis
{
   public class LogHandler
    {
        public void addLog(string path)
        {
            TextWriter tw = new StreamWriter(@"C:\Users\mateusz.kurowski\Desktop\Thesis\log.txt", true);
            tw.WriteLine("X");
            tw.Close();
        }
    }
}