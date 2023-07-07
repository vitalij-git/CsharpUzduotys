using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Projektas_Protmusis
{
    internal class Program
    {
        static ConsoleKeyInfo button;
        static Dictionary<string, string> allUsersResults = new Dictionary<string, string>();
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

        static void Menu(List<string> usersFinalResults=null)
        {
            Console.Clear();
            Console.WriteLine("1 - Atsijungimas\n" +
                "2 - Pradeti zaidima\n" +
                "3 - Statistika\n" +
                "4 - Žaidimo taisyklių atvaizdavimas\n" +
                "5 - Išėjimas iš žaidimo");
           
            
            if (usersFinalResults != null)
            {
                allUsersResults.Add(usersFinalResults[0], usersFinalResults[1]);
            }
            
            while (true)
            {
               var button1 = Console.ReadKey();
               if (button1.Key == ConsoleKey.D1)
                {
                    LogOut();
                }
               else if (button1.Key == ConsoleKey.D2)
                {
                    usersFinalResults=StartGame();
                }
               else if (button1.Key == ConsoleKey.D3)
                {
                    Statistic(allUsersResults);
                }
               else if (button1.Key == ConsoleKey.D4)
                {
                    Rules();
                }
               else if  (button1.Key == ConsoleKey.D5)
                {
                    ExitGame();
                }
                else
                {
                    Console.WriteLine("\nPaspadete bloga mygtuka");
                    continue;
                }
                
            }
            
        }
        
        static void Rules()
        {
            Console.Clear();
            Console.WriteLine("Sveikiname prisijungus prie X protmūšio programos. Šis protmūšis jums leidžia pasirinkti iš X klausimų kategorijų. Pasirinkus kategoriją pradėsite žaidimą ir turėsite pasirinkti iš 4 galimų variantų, kuris yra jūsų klausimui teisingas atsakymas.");
            Console.WriteLine("Spaukite Q, kad grižti meniu arba E išeiti iš žaidimo");
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
                    Console.WriteLine("\nPaspadete bloga mygtuka");
                    continue;
                }
            }
        }

        static List<string> StartGame()
        {
            Console.WriteLine("\nIveskite savo varda: ");
            string userName = Console.ReadLine();
            Dictionary<string, List<string>> gameQuests = GameCategory();
            Dictionary<string, string> userCorrectAnswers = new Dictionary<string, string>();
            Dictionary<string, string> userWrongAnswers = new Dictionary<string, string>();
            List<string> chosenWrongAnswer=new List<string>(); 
            List<string> userResult=new List<string>();
            userResult.Add(userName);
            int number = 1;
            int correctAnswer = 0;
            string userAnswer="";
            foreach (var item in gameQuests)
            {
                Console.Clear();
                Console.WriteLine($"{number}/10");
                Console.WriteLine("Jeigu norite grįžti meniu, spauskite Q");
                Console.WriteLine($"\n{item.Key} \n 1.{item.Value[0]}\n 2.{item.Value[1]}\n 3.{item.Value[2]}\n 4.{item.Value[3]}");
                userAnswer = UserAnswers(item);
                if (userAnswer == item.Value[4])
                {   

                    userCorrectAnswers.Add( item.Key, item.Value[4]);
                    correctAnswer++;
                }
                else
                {
                    chosenWrongAnswer.Add(userAnswer);
                    userWrongAnswers.Add(item.Key, item.Value[4]); ;
                }
                number++;
            }
            string questsResult = CorrectAnswerOutput(userCorrectAnswers, userWrongAnswers, chosenWrongAnswer);
            Console.WriteLine(questsResult);
            Console.WriteLine("\nteisingu atsakymu: "+correctAnswer);
            userResult.Add(correctAnswer.ToString());
            Console.WriteLine("Paspauksite bet koki mygtuka, kad grįžti meniu");
            Console.ReadKey();
            Menu(userResult);
            return userResult;
                    
        }
        static string UserAnswers(KeyValuePair<string,List<string>> item)
        {
            string userAnswer = "";
            button = Console.ReadKey();
            if (button.Key == ConsoleKey.D1)
            {
                userAnswer += item.Value[0];
            }
            else if (button.Key == ConsoleKey.D2)
            {
                userAnswer += item.Value[1];
            }
            else if (button.Key == ConsoleKey.D3)

            {
                userAnswer += item.Value[2];
            }
            else if (button.Key == ConsoleKey.D4)
            {
                userAnswer += item.Value[3];
            }
            else if (button.Key == ConsoleKey.Q)
            {
                Menu();
                userAnswer = null;
                return userAnswer;
            }
            else
            {
                userAnswer += item.Value[0];
            }
            
        return userAnswer;
        }

        static string CorrectAnswerOutput(Dictionary<string,string> userCorrectAnswers, Dictionary<string, string> userWrongAnswers, List<string> chosenWrongAnswer)
        {   StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\nAtsakyta teisingai");
            int i = 0;
            foreach(var item in userCorrectAnswers)
            {
                stringBuilder.Append($"\n{item.Key}\n teisingas atsakymas: {item.Value}");
            }
            stringBuilder.Append("\n\nAtsakyta neteisingai");
            foreach (var item in userWrongAnswers)
            {
                stringBuilder.Append($"\n{item.Key}\n pasirinkote: {chosenWrongAnswer[i]}\n teisingas atsakymas: {item.Value}");
                i++;
            }
            return stringBuilder.ToString();
           
        }

        static Dictionary<string, List<string>> GameCategory()
        {
            Console.Clear();
            Console.WriteLine("Pasirinkite kategorija:");
            Console.WriteLine("1 - Geografija\n2 - Istorija\n3 - Bendri\n4 - Smagus");
            Console.WriteLine("paspauskite Q jei norite grižti meniu arba E išeiti iš žaidimo");
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
                    Console.WriteLine("\nPaspadete bloga mygtuka");
                    continue;
                }
                
            }

            return gameQuests;
        }

        static Dictionary<string,List<string>> AQuestionsOfGeography()
        {
            Dictionary<string, List<string>> geography = new Dictionary<string, List<string>>()
            {
                { "Kokia yra Italijos sostinė?", new List<string>() { "Milano", "Roma", "Florencija", "Neapolis", "Roma" } },
                { "Kuri šalis turi didžiausią teritoriją pasaulyje?", new List<string>() { "Rusija", "Kanada", "Kinija", "Jungtines Amerikos Valstijos", "Rusija" } },
                { "Koks yra didžiausias pasaulio vandenynas?", new List<string>() { "Ramiojo vandenynas", "Atlanto vandenynas", "Indijos vandenynas", "Arkties vandenynas", "Ramiojo vandenynas" } },
                { "Koks yra didžiausias žemynas pasaulyje?", new List<string>() { "Europa", "Azija", "Afrika", "Australija", "Azija" } },
                { "Kuri šalis turi didžiausią gyventojų skaičių pasaulyje?", new List<string>() { "Indija", "Kinija", "Jungtinės Amerikos Valstijos", "Rusija", "Kinija" } },
                { "Kuri šalis yra didžiausia pagal plotą Europoje?", new List<string>() { "Prancūzija", "Vokietija", "Ukraina", "Švedija", "Ukraina" } },
                { "Kuri kalba yra daugiausiai kalbėta pasaulyje?", new List<string>() { "Anglų", "Kinų", "Ispanų", "Arabų", "Anglų" } },
                { "Koks yra didžiausias Afrikos šalis teritorijos atžvilgiu?", new List<string>() { "Nigerija", "Kongo Demokratinė Respublika", "Juodkalnija", "Alžyras", "Alžyras" } },
                { "Kiek šalių yra Europoje?", new List<string>() { "41", "44", "45", "39", "44" } },
                { "Koks yra didžiausias miestias pasaulyje pagal gyventojų skaičių?", new List<string>() { "Pekinas", "Tokijas", "Seulas", "Mumbajus", "Tokijas" } }
            };
            return geography;

        }

        static Dictionary<string, List<string>> AQuestionsOfHistory()
        {
            Dictionary<string, List<string>> history = new Dictionary<string, List<string>>()
            {
                { "Kuri šalis buvo Europos kolonizatorė didžiojoje dalį Afrikos?", new List<string>() { "Didžioji Britanija", "Prancūzija", "Portugalija", "Vokietija", "Portugalija" } },
                { "Kas buvo Amerikos pilietinio karo prezidentas?", new List<string>() { "Abrahamas Linkolnas", "Džefersonas Deivisas", "Andrew Johnsonas", "Ulysses Grantas", "Abrahamas Linkolnas" } },
                { "Kuri mokslo sritis buvo Galilėjo Galilėjaus specialybė?", new List<string>() { "Fizika", "Chemija", "Astronomija", "Biologija", "Astronomija" } },
                { "Kuri šalis įvykdė Pearl Harboro puolimą 1941 m.?", new List<string>() { "Japonija", "Vokietija", "Italija", "Suomija", "Japonija" } },
                { "Kada įvyko Prancūzijos revoliucija?", new List<string>() { "1776 m.", "1789 m.", "1804 m.", "1848 m.", "1789 m." } },
                { "Kuri civilizacija pastatė Machu Picchu?", new List<string>() { "Inka", "Aztekai", "Majai", "Toltekai", "Inka" } },
                { "Kas vadovavo Rusijai per Rusijos revoliuciją 1917 m.?", new List<string>() { "Caras Nikolajus II", "Vladimiras Leninas", "Josifas Stalinas", "Aleksandras Kerenskis", "Vladimiras Leninas" } },
                { "Kokia buvo Pirmojo pasaulinio karo pradžios data?", new List<string>() { "1914 m.", "1915 m.", "1917 m.", "1918 m.", "1914 m." } },
                { "Kas vadovavo JAV per Kubos raketų krizę?", new List<string>() { "Johnas F. Kenedis", "Lyndonas B. Johnsonas", "Richardas Nixonas", "Ronaldas Reaganas", "Johnas F. Kenedis" } },
                { "Kada įvyko Berlyno sienos griuvimas?", new List<string>() { "1945 m.", "1956 m.", "1989 m.", "1991 m.", "1989 m." } }
            };
            return history;
        }
        static Dictionary<string, List<string>> GeneralQuestions()
             {
                Dictionary<string, List<string>> geography = new Dictionary<string, List<string>>()
                {
                    { "Kokia religija yra dominuojanti Indijoje?", new List<string>() { "Krikščionybė", "Islamas", "Hinduizmas", "Budizmas", "Hinduizmas" } },
                    { "Kuri šalis yra gimtoji Albertui Einsteinui?", new List<string>() { "Vokietija", "Jungtinė Karalystė", "Austrija", "Šveicarija", "Austrija" } },
                    { "Kuri jūra skiria Europą nuo Afrikos?", new List<string>() { "Viduržemio jūra", "Juodoji jūra", "Baltijos jūra", "Adrijos jūra", "Viduržemio jūra" } },
                    { "Kuri šalis surengė pirmąjį modernųjį olimpinių žaidynių renginį?", new List<string>() { "Graikija", "Prancūzija", "Jungtinė Karalystė", "Jungtinės Amerikos Valstijos", "Graikija" } },
                    { "Kas parašė tragediją \"Hamletas\"?", new List<string>() { "Williamas Shakespeare'as", "Johannas Wolfgangas Goethe", "Antonis Čechovas", "Molière'as", "Williamas Shakespeare'as" } },
                    { "Kuris mokslininkas suformulavo Reliatyvumo teoriją?", new List<string>() { "Albertas Einsteinas", "Isaacas Newtonas", "Nikolaus Kopernikus", "Galilėjas", "Albertas Einsteinas" } },
                    { "Koks buvo Romos imperijos pabaigos metai?", new List<string>() { "410 m.", "476 m.", "534 m.", "632 m.", "476 m." } },
                    { "Kuri iš šių šalių nėra Baltijos jūros pakrantėje?", new List<string>() { "Estija", "Latvija", "Lenkija", "Lietuva", "Lenkija" } },
                    { "Kuri valstybė yra \"Laimės šalis\"?", new List<string>() { "Kosta Rika", "Šveicarija", "Danija", "Norvegija", "Kosta Rika" } },
                    { "Kuri šalis yra garsi dėl tulpių ir vėjo malūnų?", new List<string>() { "Nyderlandai", "Norvegija", "Suomija", "Vokietija", "Nyderlandai" } }
                };
                return geography;
            }

            static Dictionary<string, List<string>> FunnyQuestions()
            {
                Dictionary<string, List<string>> funny = new Dictionary<string, List<string>>()
                {
                    { "Ką galima paruošti, tačiau niekada negalėsi suvalgyti? ", new List<string>() { "Maisto", "Pamokų", "Pieno", "Darbo", "Pamokų" } },
                    { "Kuris automobilio ratas nesisuka važiuojant?", new List<string>() { "Priekinis", "Galinis", "Atsarginis", "Visi", "Atsarginis" } },
                    { "Turi dantis, bet valgyti negali, kas?", new List<string>() { "Šukos", "Medis", "Automobilis", "Lova", "Šukos" } },
                    { "Kas priklauso tik jums, bet jį visi kiti naudoja nuolat?", new List<string>() { "Raktas","Tavo Vardas", "Tavo daiktai", "Telefonas", "Tavo Vardas" } },
                    { "Kas žiemą kambaryje užšąla, o lauke ne?", new List<string>() { "Lango stiklas", "Vanduo", "Maistas", "Durys", "Lango stiklas" } },
                    { "Ką galima pamatyti užmerktomis akimis?", new List<string>() { "Filmą", "Serialą", "Sapną", "Fotografiją", "Sapną" } },
                    { "Kas yra tarp kalno ir slėnio", new List<string>() { "Kalnas", "Slėnis", "Ir", "Nieko", "Ir" } },
                    { "Suspausi – klynas, ištiesi – blynas. Kas?", new List<string>() { "Kelnes", "Raktas", "Piniginė", "Skėtis", "Skėtis" } },
                    { "Kas dienos metu tuščias, o naktį pilnas?", new List<string>() { "Stalas", "Lova", "Kėdė", "Baseinas", "Lova" } },
                    { "Septyni broliai turi po vieną seserį. Kiek iš viso seserų??", new List<string>() { "1", "2", "5", "7", "1" } }
                };
                return funny;
            }

            static void Statistic(Dictionary<string,string> usersFinalResults)
        {
            Console.Clear();
            Console.WriteLine("paspauskite Q jei norite grižti meniu arba E išeiti iš žaidimo");
            var sortedKeyValuePairs = usersFinalResults.OrderBy(x => x.Value).ToList();
            int i = 1;
            //usersFinalResults.;
            foreach (var item in  sortedKeyValuePairs)
            {
                Console.WriteLine($"{i}. {item}");
                i++;
            }
           
            button = Console.ReadKey();
            if (button.Key == ConsoleKey.Q)
            {
                Menu();
            }
            else if (button.Key == ConsoleKey.E)
            {
                ExitGame();
            }
        }

            static void LogOut()
            {
                Console.Clear();
                Console.WriteLine("Vyksta atsijungimas...");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Main();
            }

            public static void ExitGame()
            {
                Console.Clear();
                Console.WriteLine("Vyksta žaidimo uždarymas...");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }

    }   

}