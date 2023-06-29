using System.Text;
using System.Threading.Channels;

namespace _11.DebugAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DecimalHour("30.30")); 
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6_1();
            Task6_2();


            
        }
            
        public static string? DecimalHour(string input)
        {
            bool isInputValid = IsDecimalHourInputValid(input, out string? msg);
            if (!isInputValid)
            {
                return msg;
            }
            return msg;
        }

        private static bool IsDecimalHourInputValid(string input, out string? msg)
        {
            msg = null;
            string[] textValue = input.Split('.');
            if (IsInputTimeValid(textValue))
            {
                msg = "Invalid time";
                return false;
            }
            if(IsInputHourInvalid(textValue))
            {
                msg = "Invalid time";
                return false;
            }
            if (IsInputMinuteInvalid(textValue))
            {
                msg = "Invalid time";
                return false;
            }
            return true;
        }

        private static bool IsInputMinuteInvalid(string[] textValue)
        {
            return !int.TryParse(textValue[0], out int minute) || minute < 0 || minute > 24;
        }

        private static bool IsInputHourInvalid(string[] textValue)
        {
            return !int.TryParse(textValue[0], out int hour) || hour < 0 || hour > 24;
        }

        private static bool IsInputTimeValid(string[] textValue)
        {
            return textValue.Length < 2 ;
        }

        static void Task1()
        {
            int a = 10;
            int b = 5;
            int c = 8;
            int max = a;

            if (b> max)
            {
                max = b;
            }
            if (c> max)
            {
                max = c;
            }
            Console.WriteLine("The maximum value is: " + max);
        }

        static void Task2()
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName +" "+lastName;
            Console.WriteLine("Full Name: " + fullName);
        } 

        static void Task3()
        {
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine("Counter: " + counter);
                counter++;
            }


        }

        static void Task4()
        {
            int i = 1;
            while (i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void Task5()
        {
            string name1 = "john";
            string name2 = "John";
            
            if (name1.Equals(name2.ToLower()))
            {
                Console.WriteLine("Name are the same");
            }
            else
            {
                Console.WriteLine("Name are diffrent.");
            }
        }
        
        static void Task6_1()
        {
            string inputText = Console.ReadLine();
            string reverseText = Reverse(inputText);
            Console.WriteLine(reverseText);
        }
        public static string Reverse( string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        static void Task6_2()
        {
            string inputText = Console.ReadLine();
            string newString = RemoveDuplicate(inputText);
            Console.WriteLine(newString);
        }

        static string RemoveDuplicate( string inputText)
        {
            StringBuilder unicText = new StringBuilder();
            for(int i = 0; i < inputText.Length; i++)
            {
                if (unicText.ToString().IndexOf(inputText[i])==-1)
                {
                    unicText.Append(inputText[i]);
                }
            }
            return unicText.ToString();
        }

    }
}