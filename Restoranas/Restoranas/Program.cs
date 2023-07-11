using System.Text;

namespace Restoranas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<int> orderWaiting = new List<int>();
            List<Dictionary<string,double>> clientOrder = new List<Dictionary<string,double>>();  
            Dictionary<int, int> tableList = TableList();
            int tableID = TableRezervation(tableList);
            tableList[tableID]--;
            orderWaiting.Add(tableID);
            List<Dictionary<string, string>> menu = RestaurantMenu();
            clientOrder = GetOrderFromTable(menu, orderWaiting, clientOrder);
            OrderReceipt(clientOrder);
            Console.ReadKey();  
        }

        static List<Dictionary<string, string>> RestaurantMenu()
        {
            return new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    {"Patiekalas","Mėsainis su plėšyta kiauliena"},
                    {"Kaina","8" },
                    {"Aprašymas","plėšyta kiauliena, svogūnų džemas, bandelės, sūris, BBQ padažas"}
                },

                new Dictionary<string, string>()
                {
                    {"Patiekalas","Mėsainis su vištiena"},
                    {"Kaina","7"},
                    {"Aprašymas","kepta vištiena, mocarela, čili-mango padažas, svogūnų džemas, bandelė"}
                },
                new Dictionary<string, string>()
                {
                    {"Patiekalas","Kiaulienos išpjovos kepsneliai"},
                    {"Kaina","9.5"},
                    {"Aprašymas","kiaulienos išpjova, keptos šparaginės pupelės, bulvių pyragėliai, barbekiu padažas"}
                },
                 new Dictionary<string, string>()
                {
                    {"Patiekalas","Vištienos kepsneliai"},
                    {"Kaina","8.5"},
                    {"Aprašymas","vištienos šlaunelių mėsa, saldžių bulvių lazdelės, grill agurkai ir paprikos"}
                },
                  new Dictionary<string, string>()
                {
                    {"Patiekalas","Starkio užkepėlė"},
                    {"Kaina","10.5"},
                    {"Aprašymas","starkis, ryžiai, brokoliai, žiediniai kopūstai, mini morkytės, mėlynojo pelėsinio sūrio padažas"}
                },
                   new Dictionary<string, string>()
                {
                    {"Patiekalas","Midijos baltojo vyno padaže"},
                    {"Kaina","17"},
                    {"Aprašymas","midijos, baltoj vyno padažas, citrina"}
                }

            };
        }

        static Dictionary<int,int> TableList()
        {
            return new Dictionary<int, int>()
            {
                { 1, 4 },
                { 2, 0 },
                { 3, 6 },
                { 4, 6 },
                { 5, 4 },
            };
        }

        static int TableRezervation(Dictionary<int, int> tableList)
        {
            Console.WriteLine("Kiek žmonių reikia pasodinti prie staliuko");
            int numberOfClients = GetClientsNumberFromInput(out string input);
            int chosenTableID = CheckFreeTable(tableList, numberOfClients);
            return chosenTableID;

        }

        //Paduodam stringa. Su tryparse tikrina ar paduodamas skaisius mums tinka
        static int GetClientsNumberFromInput(out string input)
        {
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out var client))
                {
                    break;
                }
                Console.WriteLine("Parašykite sveikąjį skaičių");

            }
            return Convert.ToInt32(input);
        }

        //Pagal klientu skaiciu, ieskom staliuko, jeigu nerandma grazinam 0
        static int CheckFreeTable(Dictionary<int, int> tableList, int numberOfClients)
        {
            if (tableList.ContainsKey(numberOfClients) && tableList[numberOfClients]>0)
            {
                Console.WriteLine($"Yra laisvas staliukas {numberOfClients} klientams");
                return numberOfClients;
            }
            else if (tableList.ContainsKey(numberOfClients+1) && tableList[numberOfClients+1] > 0)
            {
                Console.WriteLine($"Yra galimybė pasodinti prie {numberOfClients+1} vietų staliuko");
                return numberOfClients+1;
            }
            return numberOfClients=0;
        }

        //Gauti menu uzsakyma is klientu
        static List<Dictionary<string, double>> GetOrderFromTable(List<Dictionary<string, string>> menu, List<int> orderWaiting, List<Dictionary<string, double>> clientOrder)
        {
            bool orderStatus = true;
            while (orderStatus == true)
            {   Console.Clear();
                MenuOuput(menu);
                Console.WriteLine("Pridėkite norima patiekala prie užskayma, parašius pagal patiekalo ID");
                int dishID = GetClientsNumberFromInput(out string input);
                clientOrder = ChosenDish(menu, dishID, clientOrder);
                Console.WriteLine("Ar norite dar pridėti patiekalą?\n1 - taip\n2 - ne");
                dishID = GetClientsNumberFromInput(out input);
                switch (dishID)
                {
                    case 1:
                        continue;
                    case 2:
                        orderStatus = false;
                        break;
                    default:
                        Console.WriteLine("Ivyko klaida");
                        continue;
                }
            }
            return clientOrder;
            
        }

        //Menu isvedimas
        static void MenuOuput(List<Dictionary<string, string>> menu)
        {
            Console.Clear();
            int i = 1;
            foreach (var item in menu)
            {
                Console.WriteLine($"{i}.{item["Patiekalas"]} .........................{item["Kaina"]} \u20AC");
                Console.WriteLine($"Patiekalo aprašymas: {item["Aprašymas"]}");
                i++;
            }
        }

        //Patiekalo pridėjimas
        static List<Dictionary<string, double>> ChosenDish(List<Dictionary<string, string>> menu, int dishID, List<Dictionary<string, double>> clientOrder)
        {
           switch (dishID.ToString())
            {
                case "1":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[0]["Patiekalas"], Convert.ToDouble(menu[0]["Kaina"]) }
                    });
                    break;
                case "2":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[1]["Patiekalas"], Convert.ToDouble(menu[1]["Kaina"]) }
                    });
                    break;
                case "3":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[2]["Patiekalas"], Convert.ToDouble(menu[2]["Kaina"]) }
                    });
                    break;
                case "4":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[3]["Patiekalas"], Convert.ToDouble(menu[3]["Kaina"]) }
                    });
                    break;
                case "5":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[4]["Patiekalas"], Convert.ToDouble(menu[4]["Kaina"]) }
                    });
                    break;
                case "6":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[5]["Patiekalas"], Convert.ToDouble(menu[5]["Kaina"]) }
                    });
                    break;
                default: 
                    Console.WriteLine("Ivyko klaida");
                    break;
            }  
            return clientOrder;

        }  
        
        //kvitas
        static void OrderReceipt(List<Dictionary<string, double>> clientOrder)
        {  
            foreach(List<KeyValuePair<string, double>> item in clientOrder)
            {
                Console.WriteLine(item.Key);
               
            }
        }
    }
}