namespace _16._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RetrieveTownPopuliation();
            WordBook();
            Console.ReadKey();
        }

        static void WordBook()
        {
            Dictionary<string, int> users = new Dictionary<string, int>
            {
                {"Tomas",25},
                {"Jonas",32},
                {"Saulius",29}
            };
            foreach (var user in users)
            {
                Console.WriteLine($"vardas {user.Key} amzius {user.Value}");
            }
        }

        static void RetrieveTownPopuliation()
        {
            Dictionary<string, int> townDictionary = new Dictionary<string, int>
            {
                {"vilnius", 500000 },
                {"kaunas", 400000 },
                {"siauliau", 300000}
            };
            Console.WriteLine("Iveskite miesta: ");
            string town = Console.ReadLine().ToLower();

            if(townDictionary.ContainsKey(town)) 
            {
                Console.WriteLine($"Gyventoju skaicius {townDictionary[town]}");
            }
            else
            {
                Console.WriteLine("Tokio miesto nera bazeje");
            }
           


        }

    }
}