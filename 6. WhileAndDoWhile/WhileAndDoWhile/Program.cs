using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WhileAndDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskNr1(); 
            //TaskNr1_1();
            //TaskNr1_2();
            // TaskNr2();
            //TaskNr2_1();
            //TaskNr2_2();
            //TaskNr3();
            //TaskNr3_1();
            //TaskNr3_2();
            //TaskNr4();
            TaskNr4_1();

        }
        static void TaskNr1()
        {
            int x = 0;
            while (x <6) { 
                Console.WriteLine(x);
                x++;
                
            }
            x = 5;
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
        }
        static void TaskNr1_1()
        {
            int x = 0;
            while (x <=10) {
                Console.WriteLine(x);
                x += 2;
            }
            x = 1;
            while (x <= 9)
            {
                Console.WriteLine(x);
                x += 2;
            }
          
        }
        static void TaskNr1_2()
        {
            int x = 0;
            while (x <= 100)
            {
                Console.WriteLine("Ciklas veiks kol skaicius mazesnis uz 100");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }
            while (x > 0)
            {
                Console.WriteLine("ciklas veiks kol skaicius daugiau uz 0");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }

        }
        static void TaskNr2()
        {
            int x = int.Parse(Console.ReadLine());
            int result = 1;
            while (x>0) {
               result *= x;
                x--;
            }
            Console.WriteLine(result);
        }
        static void TaskNr2_1() {
            var number = Console.ReadLine();
            var newNumber="";
            while (number.Length >=1)
            {
                newNumber += number[0]+",";
                number = number.Remove(0, 1);
                
            }
            newNumber = newNumber.Remove(newNumber.Length-1,1);
            Console.WriteLine(newNumber);
        }
        static void TaskNr2_2()
        {
            int starsNumber = int.Parse(Console.ReadLine());
            int number = 0;
            int number1 = 0;
            var stars = new StringBuilder();
            var star = "";
            while (number < starsNumber)
            {
                number++;
                stars.Append("*");
                Console.WriteLine(stars.ToString());
            }
            while (number1 < starsNumber)
            {
                number1++;
                star += "*";
                Console.WriteLine(star);
                
            }
        }
        static void TaskNr3()
        {
            bool isOk = false;
            var goodNumber = "";
            while (isOk!=true)
            {
                 goodNumber = Console.ReadLine();
                if (int.TryParse(goodNumber, out int integer))
                {
                    isOk = true;
                }
                else { Console.WriteLine("Iveskite sveikaji skaiciu"); }
            }
            Console.WriteLine(goodNumber);
        }
        static void TaskNr3_1()
        {
            Console.Write("Iveskite skaiciu: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("Iveskite lapsni kuri norite pakelti: ");  
            double pow = double.Parse(Console.ReadLine());
            double result = Math.Pow(number, pow);
            Console.WriteLine(result);
        }
        static void TaskNr3_2()
        {
            Console.WriteLine("Nurodyti skaiciu");
            var userNumber = Console.ReadLine();
            Console.WriteLine("Nurodyti grupiu kieki");
            int userGroup = int.Parse(Console.ReadLine());
            var result = "";
            int number = 0;
            var resultNumber = new StringBuilder();
            while (number <= userGroup)
            {
                resultNumber.Append(userNumber);
                result += resultNumber + " -> ";
                number++;
            }
            Console.WriteLine(result);
        }
        static void TaskNr4() {
            Console.WriteLine("Sveikasis skaicius");
            int userIntNumber = int.Parse(Console.ReadLine());
            int sizeCycle = 1;

            while(sizeCycle <= userIntNumber)
            {
                int secondCycle = 0;
                while(sizeCycle > secondCycle)
                {
                    secondCycle++;
                    Console.Write(sizeCycle);
                    
                }
                Console.WriteLine();
                sizeCycle++;
            }
        
        }
        static void TaskNr4_1()
        {
            int banknotes10 = 30;
            int banknotes20 = 30;
            int banknotes50 = 20;
            int sumBanknotes10 = 0;
            int sumBanknotes20 = 0;
            int sumBanknotes50 = 0;
            Console.Write("Pinigu suma: ");
            int userMoneySum = Convert.ToInt32(Console.ReadLine());
            int moneySum = userMoneySum;
            while(moneySum >= 10)
            {
                if(moneySum >= 50 && banknotes50>=1)
                {
                    sumBanknotes50++;
                    moneySum -= 50;
                    banknotes50--;
                    continue;
                }
                if (moneySum >= 20&& banknotes20 >=1)
                {
                    sumBanknotes20++;
                    moneySum -= 20;
                    banknotes20--;
                    continue;
                }
                if (moneySum >= 10 && banknotes10>=1)
                {
                    sumBanknotes10++;
                    moneySum -= 10;
                    banknotes10--;
                    continue;
                }
                else
                {
                    Console.WriteLine($"Atsiprasome baigesi bankomate banknotai. Ismoketa suma: {userMoneySum - moneySum}");
                    break;
                }
            }
            Console.WriteLine($"Kiekis 50 euru bankotu: {sumBanknotes50}\nKiekis 20 euru bankotu: {sumBanknotes20}\nKiekis 10 euru bankotu: {sumBanknotes10}");
        }

    }
}