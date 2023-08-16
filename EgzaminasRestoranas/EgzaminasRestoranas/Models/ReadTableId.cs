using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace EgzaminasRestoranas.Models
{
    internal class ReadTableId
    {
        public int ReadTableFromFile()
        {
            string readText = File.ReadAllText(@"C:\Users\Vitalis\Desktop\Programavimo darbai\EgzaminasRestoranas\EgzaminasRestoranas\bin\Debug\ChosenTableID.txt");
            return int.Parse(readText);
        }
    }
}
