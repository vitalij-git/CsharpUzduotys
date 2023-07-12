﻿using System.Text;

namespace Restoranas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            RestaurantTerminal();
            Console.ReadKey();  
        }

        static void RestaurantTerminal()
        {
            Dictionary<string,List<Dictionary<string,string>>> orderID = new Dictionary<string, List<Dictionary<string,string>>>();
            List<Dictionary<string, double>> clientOrder = new List<Dictionary<string, double>>();
            List<Dictionary<string, double>> restaurantOrder = new List<Dictionary<string, double>>();
            Dictionary<int, int> tableList = TableList();
            List<Dictionary<string, string>> menu = RestaurantMenu();
            int tableID=0;
            
            while (true)
            {   
                Console.Clear();
                RestaurantTerminalMenu();
                var chosenTerminalOption = GetClientsNumberFromInput(out string input);
                switch (chosenTerminalOption)
                {
                    case 1:
                        tableID = TableRezervation(tableList);     
                        if (tableID != 0)
                        {
                            string clientName = ClientName();
                            List<Dictionary<string, string>> orderDetails = new List<Dictionary<string, string>>();
                            orderDetails.Add(new Dictionary<string, string>()
                            { {"StaliukoID", tableID.ToString()} });
                            orderID.Add(clientName, orderDetails);         
                            tableList[tableID]--;
                        }
                        break;
                    case 2:
                        WaitingOrders(orderID);
                        Console.ReadKey();
                        if (orderID.Count() >= 1)
                        {
                            clientOrder = GetOrderFromTable(menu, clientOrder, orderID, restaurantOrder);
                        }
                        break;
                    case 3:
                        IssueReceipt(orderID);
                        Console.ReadKey();
                        //if (orderReceiptStatus == true)
                        //{
                        //    tableList[tableID]++;
                        //}
                        break;
                     case 4:
                        AddDishToMenu(menu);
                        break;
                     case 5:
                         MenuOutput(menu);
                        Console.WriteLine("Paspauskite bet kokį mygtuką, kad grižtį į menu");
                        Console.ReadKey();
                        break;
                     case 6:
                        RestaurantReceipt(restaurantOrder);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
            
        }
        
        static void RestaurantTerminalMenu()
        {
            Console.WriteLine("Pasirinkite norima opcija:" +
                "\n1 - Pasodinti klienta" +
                "\n2 - Priimti užsakyma" +
                "\n3 - Išrašyti čekį" +
                "\n4 - Pridėti Patiekala" +
                "\n5 - Peržiūrėti meniu" +
                "\n6 - Restorano kvitas");

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
                { 1, 3 },
                { 2, 5 },
                { 3, 5 },
                { 4, 4 },
                { 5, 3 },
                { 6, 2 },
            };
        }

        //Priskirti staliuka
        static int TableRezervation(Dictionary<int, int> tableList)
        {
            Console.WriteLine("Kiek žmonių reikia pasodinti prie staliuko");
            int numberOfClients = GetClientsNumberFromInput(out string input);
            return CheckFreeTable(tableList, numberOfClients);

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
                Console.WriteLine($"Yra laisvas staliukas {numberOfClients} klientams, Patvirnkite paspaude mygtuka");
                Console.ReadKey();
                return numberOfClients;
            }
            else if (tableList.ContainsKey(numberOfClients+1) && tableList[numberOfClients+1] > 0)
            {
                Console.WriteLine($"Yra galimybė pasodinti prie {numberOfClients+1} vietų staliuko,Patvirnkite paspaude mygtuka");
                Console.ReadKey();
                return numberOfClients+1;
            }
            else
            {
                Console.WriteLine("Per daug klientų, Reikia sujungti stalų, patvirnti spauskite bet kokį mygtuką");
                Console.ReadKey();
                while (numberOfClients > 0)
                {
                    if (tableList[6] > 0 && numberOfClients>=6) 
                    {
                        numberOfClients = numberOfClients - 6;
                        tableList[6]--;
                        continue;
                    }
                    else if (tableList[5] > 0 && numberOfClients >= 5)
                    {
                        numberOfClients = numberOfClients -5;
                        tableList[5]--;
                        continue;
                    }
                    else if (tableList[4] > 0 && numberOfClients >= 4)
                    {
                        numberOfClients = numberOfClients - 4;
                        tableList[4]--;
                        continue;
                    }
                    else if (tableList[3] > 0 && numberOfClients >= 3)
                    {
                        numberOfClients = numberOfClients - 3;
                        tableList[3]--;
                        continue;
                    }
                    else if (tableList[2] > 0 && numberOfClients >= 2)
                    {
                        numberOfClients = numberOfClients - 2;
                        tableList[2]--;
                        continue;
                    }
                    else if (tableList[1] > 0)
                    {
                        numberOfClients = numberOfClients - 1;
                        tableList[1]--;
                        continue;
                    }
                    else if (numberOfClients>0)
                    {
                        Console.WriteLine("Per didelis klientų skaičius, tiek šiuo metų ne turim vietų");
                        Console.ReadKey();
                        break;
                    }
                }
                
            }
           return numberOfClients=0;
        }

        //Laukiami uzsakymai
        static void WaitingOrders(Dictionary<string, List<Dictionary<string, string>>> orderID)
        {
            StringBuilder builder = new StringBuilder();
            if (orderID.Count()==1)
            {
                foreach (var item in orderID)
                {
                    builder.Append(($"{item.Key}  staliukas vardu staliukas laukia užsakymo"));
                    
                }
            }
            else if (orderID.Count() >= 1)
            {
                foreach (var item in orderID)
                {
                    builder.Append(($"{item.Key},"));
                    
                }
                builder.Append(" vardu satliukai laukia užsakymų");
            }
            else
            {
                Console.WriteLine("Nera užaskymu");
                Console.ReadKey();
            }
            Console.WriteLine(builder.ToString());
              
        }
        //Gauti menu uzsakyma is klientu
        static List<Dictionary<string, double>> GetOrderFromTable(List<Dictionary<string, string>> menu, List<Dictionary<string, double>> clientOrder, Dictionary<string, List<Dictionary<string, string>>> orderID, List<Dictionary<string, double>> restaurantOrder)
        {
            foreach(var order in orderID)
            {
                bool orderStatus = true;
                while (orderStatus == true)
                {
                    Console.Clear();
                    Console.WriteLine($"Užsisako {order.Key} vardu");
                    MenuOutput(menu);
                    Console.WriteLine("Pridėkite norima patiekala prie užskayma, parašius pagal patiekalo ID");
                    int dishID = GetClientsNumberFromInput(out string input);
                    clientOrder = ChosenDish(menu, dishID, clientOrder, restaurantOrder);
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
                orderID[order.Key].Add(new Dictionary<string, string>()
                {
                    {
                        "Kvitas", OrderReceipt(clientOrder)
                    }
                 });
            }

            return clientOrder;
        }

        //Menu isvedimas
        static void MenuOutput(List<Dictionary<string, string>> menu)
        {
            
            int i = 1;
            foreach (var item in menu)
            {
                Console.WriteLine($"{i}.{item["Patiekalas"]} .........................{item["Kaina"]} \u20AC");
                Console.WriteLine($"Patiekalo aprašymas: {item["Aprašymas"]}");
                i++;
            }
        }

        //Patiekalo pridėjimas
        static List<Dictionary<string, double>> ChosenDish(List<Dictionary<string, string>> menu, int dishID, List<Dictionary<string, double>> clientOrder, List<Dictionary<string, double>> restaurantOrder)
        {
           switch (dishID.ToString())
            {
                case "1":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[0]["Patiekalas"], Convert.ToDouble(menu[0]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[0]["Patiekalas"], Convert.ToDouble(menu[0]["Kaina"]) }
                    });
                    break;
                case "2":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[1]["Patiekalas"], Convert.ToDouble(menu[1]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[1]["Patiekalas"], Convert.ToDouble(menu[1]["Kaina"]) }
                    });
                    break;
                case "3":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[2]["Patiekalas"], Convert.ToDouble(menu[2]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[2]["Patiekalas"], Convert.ToDouble(menu[2]["Kaina"]) }
                    });
                    break;
                case "4":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[3]["Patiekalas"], Convert.ToDouble(menu[3]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[3]["Patiekalas"], Convert.ToDouble(menu[3]["Kaina"]) }
                    });
                    break;
                case "5":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[4]["Patiekalas"], Convert.ToDouble(menu[4]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[4]["Patiekalas"], Convert.ToDouble(menu[4]["Kaina"]) }
                    });
                    break;
                case "6":
                    clientOrder.Add(new Dictionary<string, double>()
                    {
                        {menu[5]["Patiekalas"], Convert.ToDouble(menu[5]["Kaina"]) }
                    });
                    restaurantOrder.Add(new Dictionary<string, double>()
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
        static string OrderReceipt(List<Dictionary<string, double>> clientOrder)
        {
            Console.Clear();
            StringBuilder receipt = new StringBuilder();
            receipt.Append("Jusu kvitas");
            double orderPriceResult = 0;
            foreach(var list in clientOrder)
            {
                foreach(var item in list)
                {
                    receipt.Append("\n"+item.Key + "........" + item.Value);
                    orderPriceResult+=item.Value;
                }
               
            }
            receipt.Append($"\nViso........................{orderPriceResult}");
            return receipt.ToString();
        }

        static List<Dictionary<string, string>> AddDishToMenu(List<Dictionary<string, string>> menu)
        {
            Console.Clear ();
            Console.WriteLine("Patiekalo pavadinimas");
            string dishName = Console.ReadLine();
            Console.WriteLine("Patiekalo kaina");
            string dishPrice = Console.ReadLine();
            Console.WriteLine("Patiekalo aprašymas");
            string dishDescription = Console.ReadLine();
            menu.Add(new Dictionary<string, string>()
            {
                {"Patiekalas", dishName},
                {"Kaina", dishPrice },
                {"Aprašymas", dishDescription }
            });
            return menu;
        }

        //Kliento vardas
        static string ClientName()
        {
            Console.WriteLine("Parašykite kieno vardu užrašysim staliuka");
            return Console.ReadLine();
            
        }

        //Isduoti kvita
        static void IssueReceipt(Dictionary<string, List<Dictionary<string, string>>> orderID)
        {
            foreach (var list in orderID)
            {
                Console.WriteLine(list.Key);
                foreach(var item in list.Value)
                {

                    if (item.ContainsKey("Kvitas"))
                    {
                        Console.WriteLine(item["Kvitas"]);
                    }
                    
                }
            }
        }

        //Restorano kvitas
        static void RestaurantReceipt(List<Dictionary<string, double>> restaurantOrder)
        {
            Console.Clear();
            StringBuilder receipt = new StringBuilder();
            receipt.Append("Jusu kvitas");
            double orderPriceResult = 0;
            foreach (var list in restaurantOrder)
            {
                foreach (var item in list)
                {
                    receipt.Append("\n" + item.Key + "........" + item.Value);
                    orderPriceResult += item.Value;
                }

            }
            receipt.Append($"\nViso........................{orderPriceResult}");
            Console.WriteLine(receipt.ToString()); 
        }

    }
}