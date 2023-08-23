using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    internal class WorkerComboBoxItem
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }

        public override string ToString()
        {
            return $"{WorkerId} - {WorkerName}";
        }
    }
}
