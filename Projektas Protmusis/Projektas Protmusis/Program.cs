namespace Projektas_Protmusis
{
    internal class Program
    {
        static void Main()
        {
            bool connectStatus = UserLogin();
            if(connectStatus == true)
            {
                Meniu();
            }
            else if(connectStatus == false) 
            {
                Console.WriteLine("Virsytas bandymo limito kiekis");
                System.Threading.Thread.Sleep(1000);
                BotTest();
            }
            Console.ReadKey();
        }

        static bool UserLogin()
        {
            var username = "projektas";
            var password = "123456";
            int loginTryAmount = 1;

            while (loginTryAmount<=3)
            {
                Console.WriteLine("Prisijungimas");
                Console.Write("Prisijungimo vardas: ");
                var usernameFromInput = Console.ReadLine();
                Console.Write("slaptazoids: ");
                var passwordFromInput = Console.ReadLine();
                if (usernameFromInput == username && passwordFromInput == password)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"Blogai ivesti pisijungimo duomenys, bandykite dar karta(Bandymu liko {3-loginTryAmount}");
                    loginTryAmount++;
                    continue;
                }
            }
            return false;

        }

        static string GenerateRandomString()
        {   
            Console.Clear();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[8];
            var random = new Random();
            for(int i=0; i<stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(0, chars.Length)];
            }
            string randomstring = new String(stringChars);
            return randomstring;
            
        }

        static void BotTest()
        {
            var randomString = GenerateRandomString();
            Console.WriteLine("Testas ar jus ne botas?");
            while (true)
            {
                Console.WriteLine("Iveskite toki pat teksta, kuris parasytas zemiau");
                Console.WriteLine(randomString);
                var randomStringAnswer = Console.ReadLine();
                if (randomStringAnswer == randomString)
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Tekstas nesutampa, bandykite dar karta");
                    continue;
                }
            }
         
        }

        static void Meniu()
        {
            Console.WriteLine("1 - Atsijungimas\n" +
                "2 - Žaidimo taisyklių atvaizdavimas\n" +
                "3 - Žaidimo rezultatų ir dalyvių peržiūra\n" +
                "4 - Dalyvavimas (Start game)\n" +
                "5 - Išėjimas iš žaidimo");
            var meniuChoseFromInput = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(meniuChoseFromInput, out var meniuChose))
                {
                    LogOut();
                }
                else 
                { 
                    Console.WriteLine("Pasirinkote bloga pasirinkima, bandykite dar karta");
                    continue;
                }
            }
            
        }

        static  void LogOut()
        {
            Console.WriteLine("Sekmingai atsijungite");
            Main();
           
        }

        
    }

}