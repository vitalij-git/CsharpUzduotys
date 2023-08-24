
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class WorkerRoles
    {
        public WorkerRoles() { }   
        public WorkerRoles(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}