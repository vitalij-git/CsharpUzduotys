using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    internal class WorkerStatus
    {

        public List<string> GetWorkerStatus()
        {
            var userStatusList = new List<string>();
            string filePath = @"C:\Users\Vitalis\Desktop\Programavimo darbai\EgzaminasRestoranas\EgzaminasRestoranas\bin\Debug\UserStatus.txt";
            using (var streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    foreach (var part in parts)
                    {
                        userStatusList.Add(part);
                    }
                }
            }
             return userStatusList;
        }
      
    }
}
