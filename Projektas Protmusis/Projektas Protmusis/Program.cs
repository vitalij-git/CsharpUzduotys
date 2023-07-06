using System.Security.Cryptography.X509Certificates;

namespace Projektas_Protmusis
{
    internal class Program
    {
        static ConsoleKeyInfo button;
        static void Main()
        {
            bool connectStatus = UserLogin();
            if(connectStatus == true)
            {
                Menu();
            }
            else if(connectStatus == false) 
            {
                Console.WriteLine("Virsytas bandymo limito kiekis");
                System.Threading.Thread.Sleep(2000);
                BotTest();
            }
            Console.ReadKey();
        }

        static bool UserLogin()
        {
            var username = "1";
            var password = "1";
            int loginTryAmount = 1;

            while (loginTryAmount<=3)
            {
                Console.Clear();
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
                    System.Threading.Thread.Sleep(3000);
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
                Console.Clear();
                stringChars[i] = chars[random.Next(0, chars.Length)];
            }
            string randomstring = new String(stringChars);
            return randomstring;
            
        }

        static void BotTest()
        {
            Console.Clear();
            var randomString = GenerateRandomString();
            int botTestTryAmount = 1;
            Console.WriteLine("Testas ar jus ne botas?");
            while (botTestTryAmount<=3)
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
                    botTestTryAmount++;
                    continue;
                }
            }
            Console.WriteLine("Per daug padarete klaidu, Bandykite veliau");
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n1 - Atsijungimas\n" +
                "2 - Pradeti zaidima\n" +
                "3 - Statistika\n" +
                "4 - Žaidimo taisyklių atvaizdavimas\n" +
                "5 - Išėjimas iš žaidimo");
            while (true)
            {
               button = Console.ReadKey();
               if (button.Key == ConsoleKey.D1)
                {
                    LogOut();
                }
               else if (button.Key == ConsoleKey.D2)
                {
                    StartGame();
                }
               else if (button.Key == ConsoleKey.D3)
                {
                    //statistika
                }
               else if (button.Key == ConsoleKey.D4)
                {
                    Rules();
                }
               else if  (button.Key == ConsoleKey.D5)
                {
                    ExitGame();
                }
                else
                {
                    continue;
                }
                
            }
            
        }
        
        static void Rules()
        {
            Console.Clear();
            Console.WriteLine("\nSveikiname prisijungus prie X protmūšio programos. Šis protmūšis jums leidžia pasirinkti iš X klausimų kategorijų. Pasirinkus kategoriją pradėsite žaidimą ir turėsite pasirinkti iš 4 galimų variantų, kuris yra jūsų klausimui teisingas atsakymas.");
            Console.WriteLine("Spaukite Q, kad grižtį į menių arba E išeiti iš žaidimo");
            button = Console.ReadKey();
            while (true)
            {
                button = Console.ReadKey();
                if (button.Key == ConsoleKey.Q)
                {
                    LogOut();
                }
                else if (button.Key == ConsoleKey.D5)
                {
                    ExitGame();
                }
                else
                {
                    continue;
                }
               
            }
            

        }

        static void StartGame()
        {
            Dictionary<string, List<string>> gameQuests = GameCategory();
            int number = 1;
            foreach (var item in gameQuests)
            {
                Console.Clear();
                Console.WriteLine($"{number}/10");
                Console.WriteLine($"\n{item.Key} \n 1.{item.Value[0]}\n 2.{item.Value[1]}\n 3.{item.Value[2]}\n 4.{item.Value[3]}");
                Console.ReadKey();
                number++;
            }
           
        }
        static Dictionary<string, List<string>> GameCategory()
        {

            Console.WriteLine("\nPasirinkite kategorija:");
            Console.WriteLine("1 - Geografija\n2 - Istorija\n3 - Bendri\n4 - Smagus");
            Console.WriteLine("paspauskite Q jei norite grižtį į meniu arba E išeiti iš žaidimo");
            Dictionary<string, List<string>> gameQuests = new Dictionary<string, List<string>>();
            bool categoryStatus = true;
            while (categoryStatus==true)
            {
                button = Console.ReadKey();
                if (button.Key == ConsoleKey.D1)
                {
                    gameQuests = AQuestionsOfGeography();
                    categoryStatus = false;
                }
                else if (button.Key == ConsoleKey.D2)
                {
                    gameQuests = AQuestionsOfHistory();
                    categoryStatus = false;
                }
                else if (button.Key == ConsoleKey.D3)
                {
                    gameQuests = GeneralQuestions();
                    categoryStatus = false;
                }
                else if (button.Key == ConsoleKey.D4)
                {
                    gameQuests = FunnyQuestions();
                    categoryStatus = false;
                }
                else if (button.Key == ConsoleKey.Q)
                {
                    Menu();
                    categoryStatus = false;
                }
                else if (button.Key == ConsoleKey.E)
                {
                    ExitGame();
                    categoryStatus = false;
                }
                else
                {
                    continue;
                }
                
            }

            return gameQuests;
        }

        static Dictionary<string,List<string>> AQuestionsOfGeography()
        {
            Dictionary<string, List<string>> geography = new Dictionary<string, List<string>>()
            {
                { "Kokia yra Italijos sostinė?", new List<string>() { "Milano", "Roma", "Florencija", "Neapolis" } },
                { "Kuri šalis turi didžiausią teritoriją pasaulyje?", new List<string>() { "Rusija", "Kanada", "Kinija", "Jungtines Amerikos Valstijos" } },
                { "Koks yra didžiausias pasaulio vandenynas?", new List<string>() { "Ramiojo vandenynas", "Atlanto vandenynas", "Indijos vandenynas", "Arkties vandenynas" } },
                { "Koks yra didžiausias žemynas pasaulyje?", new List<string>() { "Europa", "Azija", "Afrika", "Australija" } },
                { "Kuri šalis turi didžiausią gyventojų skaičių pasaulyje?", new List<string>() { "Indija", "Kinija", "Jungtinės Amerikos Valstijos", "Rusija" } },
                { "Kuri šalis yra didžiausia pagal plotą Europoje?", new List<string>() { "Prancūzija", "Vokietija", "Ukraina", "Švedija" } },
                { "Kuri kalba yra daugiausiai kalbėta pasaulyje?", new List<string>() { "Anglų", "Kinų", "Ispanų", "Arabų" } },
                { "Koks yra didžiausias Afrikos šalis teritorijos atžvilgiu?", new List<string>() { "Nigerija", "Kongo Demokratinė Respublika", "Juodkalnija", "Alžyras" } },
                { "Kiek šalių yra Europoje?", new List<string>() { "41", "44", "45", "39" } },
                { "Koks yra didžiausias miestias pasaulyje pagal gyventojų skaičių?", new List<string>() { "Pekinas", "Tokijas", "Seulas", "Mumbajus" } }
            };
            return geography;

        }

        static Dictionary<string, List<string>> AQuestionsOfHistory()
        {
            Dictionary<string, List<string>> history = new Dictionary<string, List<string>>()
            {
                { "Kuri šalis buvo Europos kolonizatorė didžiojoje dalį Afrikos?", new List<string>() { "Didžioji Britanija", "Prancūzija", "Portugalija", "Vokietija" } },
                { "Kas buvo Amerikos pilietinio karo prezidentas?", new List<string>() { "Abrahamas Linkolnas", "Džefersonas Deivisas", "Andrew Johnsonas", "Ulysses Grantas" } },
                { "Kuri mokslo sritis buvo Galilėjo Galilėjaus specialybė?", new List<string>() { "Fizika", "Chemija", "Astronomija", "Biologija" } },
                { "Kuri šalis įvykdė Pearl Harboro puolimą 1941 m.?", new List<string>() { "Japonija", "Vokietija", "Italija", "Suomija" } },
                { "Kada įvyko Prancūzijos revoliucija?", new List<string>() { "1776 m.", "1789 m.", "1804 m.", "1848 m." } },
                { "Kuri civilizacija pastatė Machu Picchu?", new List<string>() { "Inka", "Aztekai", "Majai", "Toltekai" } },
                { "Kas vadovavo Rusijai per Rusijos revoliuciją 1917 m.?", new List<string>() { "Caras Nikolajus II", "Vladimiras Leninas", "Josifas Stalinas", "Aleksandras Kerenskis" } },
                { "Kokia buvo Pirmojo pasaulinio karo pradžios data?", new List<string>() { "1914 m.", "1915 m.", "1917 m.", "1918 m." } },
                { "Kas vadovavo JAV per Kubos raketų krizę?", new List<string>() { "Johnas F. Kenedis", "Lyndonas B. Johnsonas", "Richardas Nixonas", "Ronaldas Reaganas" } },
                { "Kada įvyko Berlyno sienos griuvimas?", new List<string>() { "1945 m.", "1956 m.", "1989 m.", "1991 m." } }
            };
            return history;
        }
        static Dictionary<string, List<string>> GeneralQuestions()
             {
                Dictionary<string, List<string>> geography = new Dictionary<string, List<string>>()
                {
                    { "Kokia yra Italijos sostinė?", new List<string>() { "Amazonė", "Nilas", "Misisipė", "Jangcas" } },
                    { "Kuris iš šių miestų yra Italijos sostinė??", new List<string>() { "Roma", "Milano", "Florencija", "Neapolis" } },
                    { "Kuri kalba yra daugiausiai kalbėta pasaulyje?", new List<string>() { "Kinų", "Anglų", "Ispanų", "Hindi" } },
                    { "Kuri šalis surengė pirmąjį modernųjį olimpinių žaidynių renginį?", new List<string>() { "Graikija", "Prancūzija", "Jungtinė Karalystė", "Jungtinės Amerikos Valstijos" } },
                    { "Kas parašė tragediją \"Hamletas\"?", new List<string>() { "Williamas Shakespeare'as", "Johannas Wolfgangas Goethe", "Antonis Čechovas", "Molière'as" } },
                    { "Kuris mokslininkas suformulavo Reliatyvumo teoriją?", new List<string>() { "Albertas Einsteinas", "Isaacas Newtonas", "Nikolaus Kopernikus", "Galilėjas Galilėjus" } },
                    { "Koks buvo Romos imperijos pabaigos metai?", new List<string>() { "410 m.", "476 m.", "534 m.", "632 m." } },
                    { "Kuri iš šių šalių nėra Baltijos jūros pakrantėje?", new List<string>() { "Estija", "Latvija", "Lenkija", "Lietuva" } },
                    { "Kuri valstybė yra \"Laimės šalis\"?", new List<string>() { "Kosta Rika", "Šveicarija", "Danija", "Norvegija" } },
                    { "Kuri šalis yra garsi dėl tulpių ir vėjo malūnų?", new List<string>() { "Nyderlandai", "Norvegija", "Suomija", "Vokietija" } }
                };
                return geography;
            }

            static Dictionary<string, List<string>> FunnyQuestions()
            {
                Dictionary<string, List<string>> funny = new Dictionary<string, List<string>>()
                {
                    { "Ką galima paruošti, tačiau niekada negalėsi suvalgyti? ", new List<string>() { "Maisto", "Pamokų", "Pienas", "Darbas" } },
                    { "Kuris automobilio ratas nesisuka važiuojant?", new List<string>() { "Priekinis", "Galinis", "Atsarginis", "Visi" } },
                    { "Turi dantis, bet valgyti negali, kas?", new List<string>() { "Šukos", "Medis", "Automobilis", "Lova" } },
                    { "Kas priklauso tik jums, bet jį visi kiti naudoja nuolat?", new List<string>() { "Raktas", "Tavo Vardas", "Tavo daiktai", "Telefonas" } },
                    { "Kas žiemą kambaryje užšąla, o lauke ne?", new List<string>() { "Lango stiklas", "Vanduo", "Maistas", "Durys" } },
                    { "Ką galima pamatyti užmerktomis akimis?", new List<string>() { "Filmą", "Serialą", "Sapną", "Fotografiją" } },
                    { "Kas yra tarp kalno ir slėnio", new List<string>() { "Kalnas", "Slėnis", "Ir", "Nieko" } },
                    { "Suspausi – klynas, ištiesi – blynas. Kas?", new List<string>() { "Kelnes", "Raktas", "Piniginė", "Skėtis" } },
                    { "Kas dienos metu tuščias, o naktį pilnas?", new List<string>() { "Stalas", "Lova", "Kėdė", "Baseinas" } },
                    { "Septyni broliai turi po vieną seserį. Kiek iš viso seserų??", new List<string>() { "1", "2", "5", "7" } }
                };
                return funny;
            }

            static void LogOut()
            {
                Console.Clear();
                Console.WriteLine("\nVyksta atsijungimas...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Main();
            }

            public static void ExitGame()
            {
                Console.Clear();
                Console.WriteLine("\nVyksta žaidimo uždarymas...");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }

    }   

}