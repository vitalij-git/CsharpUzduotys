using System.Text;

namespace Restoranas
{
    internal class Program
    {
        static void Main(string[] args)
        {   List<int> orderWaiting = new List<int>();   
            Dictionary<int, int> tableList = TableList();
            int tableID = TableRezervation(tableList);
            tableList[tableID]--;
            orderWaiting.Add(tableID);
            List<Dictionary<string, string>> menu = RestaurantMenu();
            GetOrderFromTable(menu, orderWaiting);
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

        //Paduodam kiek klientu ir Bando Su tryparse tikrinti ar paduodamas skaisius mums tinka
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
        static void GetOrderFromTable(List<Dictionary<string, string>> menu, List<int> orderWaiting)
        {
            Console.Clear();
            int i = 1;
            char euro = '€';
            foreach (var item in menu)
            {
                Console.WriteLine($"{i}.{item["Patiekalas"]} .........................{item["Kaina"]} {euro}");
                Console.WriteLine($"Patiekalo aprašymas: {item["Aprašymas"]}");
                i++;
            }
            Console.WriteLine();
        }
    }
}