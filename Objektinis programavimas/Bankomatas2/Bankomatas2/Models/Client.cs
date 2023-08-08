using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas2.Models
{
    internal class Client
    {
        public Client(int clientPin, string fullName)
        {
            ClientPin = clientPin;
            FullName = fullName;
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private int PinCode;
        public int ClientPin
        {
            get { return PinCode; }
            set { PinCode = value; }
        }
        public string FullName { get; set; }
    }
}
