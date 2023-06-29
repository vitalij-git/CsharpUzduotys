namespace third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ifas1();
            //Ifas2 ();
            //Ifas3();
            //Account();
            Task7();
        }
        static void Ifas1()
        {
            //1
            Console.Write("Iveskite Skaiciu: ");
            double number = double.Parse(Console.ReadLine());
            if (number > 100)
            {
                Console.WriteLine("Skaičius yra didesnis nei 100");
            }
            else if (number == 100)
            {
                Console.WriteLine("Skaičius yra lygus 100");
            }
            else
            {
                Console.WriteLine("Skaičius yra mažesnis nei 100");
            }
            //2 su switchu
            Console.WriteLine("Parasykite diena paga skaiciu");
            var day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Pirmadienis");
                    break;
                case "2":
                    Console.WriteLine("Antradenis");
                    break;
                case "3":
                    Console.WriteLine("Treciadienis");
                    break;
                case "4":
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case "5":
                    Console.WriteLine("Penktadienis");
                    break;
                case "6":
                    Console.WriteLine("Sestadienis");
                    break;
                case "7":
                    Console.WriteLine("Sekmadienis");
                    break;
                default:
                    Console.WriteLine("Neteisingas dienos numeris");
                    break;
            }
        }
        static void Ifas2()
        {
            //1
            Console.Write("Parasykite skaiciu: ");
            var number = double.Parse(Console.ReadLine());
            if (number % 5 == 0 && number % 2 == 0)
            {
                Console.WriteLine("Skaičius dalijasi iš 5 ir yra lyginis");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Skaičius dalijasi iš 5");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }
            else { Console.WriteLine("Skaičius neatitinka jokių sąlygų"); }

            //2 
            Console.WriteLine("Iveskite oro temperatura");
            var temperature = double.Parse(Console.ReadLine());
            if (temperature > 20)
            {
                Console.WriteLine("Karšta");
            }
            else if (temperature <= 20 && temperature >= 0)
            {

                Console.WriteLine("Vėsu");
            }
            else if (temperature < 0)
            {
                Console.WriteLine("Šalta");
            }
            else { Console.WriteLine("Klaida"); }
        }
        static void Ifas3()
        {
            Console.WriteLine("Kokia valanda jus siandien atskelete");
            var time = double.Parse(Console.ReadLine());
            if (time < 12)
            {
                Console.WriteLine("Geros dienos!");
            }
            else if (time >= 12 && time <= 18)
            {
                Console.WriteLine("Geros popietės");
            }
            else if (time >= 18 && time <= 24)
            {
                Console.WriteLine("Geros vakaro!");
            }
        }
        static void Account()
        {
            Console.WriteLine("Please, enter your password");
            var password = Console.ReadLine();
            var thisPassword = "Mellon";
            if (password == thisPassword)
            {
                Console.WriteLine("Sėkmingai prisijungėte");
            }
            else if (password == "1101001 01101110")
            {
                Console.WriteLine("Nulaužta..");
            }
            else
            {
                Console.WriteLine("laptažodis neteisingas, prašome bandyti dar kartą.");
                Account();
            }
        }
        static void Age()
        {
            Console.Write("Iveskite savo amziu: ");
            var age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Jums priklauso nepilnamečio akcija");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Jūs esate suaugęs");
            }
            else { Console.WriteLine("Jums priklauso senioro akcija"); }
        }
        static void Task5()
        {
            Console.Write("Iveskite norima metu skaiciu");
            int years = int.Parse(Console.ReadLine());
            if ((years % 4 == 0 && years % 100 != 0) || years % 400 == 0)
            {
                Console.WriteLine("Tai yra keliamieji sadai");
            }
            else
            {
                Console.WriteLine("Tai nėra keliamieji metai");
            }

        }
        static void Task6()
        {
            String[] products = { "Banana", "Apple", "Pineapple", "Strawberry", "Peach", "Melon", "Limon" };
            Console.WriteLine("1 - Banana \n2 - Apple \n3 - Pineapple \n4 - Strawberry \n5 - Peach \n6 - Melon \n7 - Limon");
            Console.WriteLine(" choose up to 3 products(write id): ");
           
        }
        static void Task7()
        {
            Console.Write("Enter of any number from 0 to 100: ");
            double number = double.Parse(Console.ReadLine());
            
            while (number <= 100 )
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("BazingaPop");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Bazinga");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Pop");
                }
                else { Console.WriteLine(number); }
                number++;
            }
        }
        static void Task8()
        {
            //1
            Console.WriteLine("Iveskite du skaicius");
            Console.Write("Pirma: ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("Antra: ");
            double second = double.Parse(Console.ReadLine());
            if (first >0 && second>0) { Console.WriteLine("Abu skaičiai yra teigia"); }
            else if(first >0 || second > 0) { Console.WriteLine("Tik vienas skaičius yra teigiama"); }
            else { Console.WriteLine("Nė vienas skaičius nėra teigiama"); }

            //2
            Console.WriteLine("Iveskite trys skaicius");
            Console.Write("Pirma: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Antra: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Trecia: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if(firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine("Visi skaičiai yra lygūs");
            }
            else if (firstNumber == secondNumber || secondNumber == thirdNumber)
            {
                Console.WriteLine("Du skaičiai yra lygū");
            }
            else
            {
               Console.WriteLine("Nė vienas skaičius nėra lygūs");
            }
        }
    }

}