using System;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace Pirmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks:");
            Console.WriteLine("First Task");
            Console.WriteLine("Second Task");
            Console.WriteLine("Write, which task you want to see");
            var k = Console.ReadLine();
            if( k == "1" || k == "first")
            {
                FirstTask();
                Console.WriteLine("Are you want back to menu?");
                var back = Console.ReadLine();
                if (back == "yes")
                {
                    Program.Main(args);
                }
                else if (back == "no")
                {
                    Environment.Exit(0);
                }
                else {
                    Console.WriteLine("Write yes or no");
                    back = Console.ReadLine();
                    while  (back != "yes" || back != "back")
                    {
                        Console.WriteLine("Write yes or no");
                        back = Console.ReadLine();
                    }
                    if (back == "yes")
                    {
                        Program.Main(args);
                    }
                    else if (back == "no")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else if (k == "2" || k == "second")
            {
                SecondtTask();
            }

            
            

        }

        static void FirstTask()
        {
            int i = 1;
            string x = "**";
            string y = "**";
            var a = "        ";

            Console.WriteLine(a + x + y);
            x += "      ";
            a = "     ";
            Console.WriteLine(a + x + y);
            x += "    ";
            a = "   ";
            Console.WriteLine(a + x + y);
            a = "  ";
            x = "**   ";
            y = "    **";
            var h = "Hello";
            Console.WriteLine(a + x + h + y);
            a = "  ";
            y = "    **";
            x = "**    ";
            var f = "From";
            Console.WriteLine(a + x + f + y);
            a = "   ";
            y = "    **";
            x = "**    ";
            var c = "C#";
            Console.WriteLine(a + x + c + y);
            a = "    ";
            Console.WriteLine(a + x + y);
            x = "**";
            y = "**";
            a = "        ";
            Console.WriteLine(a + x + y);
        }
        static void SecondtTask()
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("     /\\");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    /  \\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   /    \\");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  /______\\");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}