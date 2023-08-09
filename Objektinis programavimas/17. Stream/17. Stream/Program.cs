using System.Diagnostics;
using System.Text;

namespace _17._Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Easiest();
            //Normal();
            Advanced();
        }

        static void Easiest()
        {
            //1
            string text = File.ReadAllText(@"C:\Users\Vitalis\Desktop\HashSet.txt");
            Console.WriteLine(text);
            //2
            List<string> list = new List<string>() { "pasaulis","namas","takas","sistema" };  
            File.WriteAllLines(@"file.txt", list.ToArray());
            //3
            File.Copy(@"C:\Users\Vitalis\Desktop\HashSet.txt", @"write.txt", true);
        }

        static void Normal()
        {
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //var result = 0;
            //IEnumerable<string> longText = File.ReadLines(@"C:\Users\Vitalis\Desktop\Programavimo darbai\Objektinis programavimas\17. Stream\17. Stream\bin\Debug\net7.0\text.txt");
            //foreach (string line in longText)
            //{
            //    Console.WriteLine(line);
            //    result += line.Count();
            //}

            //Console.WriteLine("simboliu kiekis " + result);
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.Elapsed);

            //2
            using (StreamWriter sw = new StreamWriter("streamText.txt"))
            {
                sw.WriteLine("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley");
                for(int i = 0;i<10;i++)
                {
                    sw.Write(i);
                }
            }
            //3
            using (BinaryWriter binary = new BinaryWriter(File.Open("binaryFile.bin", FileMode.Create)))
            {
                binary.Write("0x80234400");
                binary.Write(true);
                binary.Write(2514);
                byte[] binaryArray = new byte[] { 0b00001111, 0b10011001 };
                binary.Write(binaryArray);
                binary.Write('V');
                binary.Write(125.25);
            }
            using (BinaryReader binaryReader = new BinaryReader(File.Open(@"C:\Users\Vitalis\Desktop\Programavimo darbai\Objektinis programavimas\17. Stream\17. Stream\bin\Debug\net7.0\binaryFile.bin", FileMode.Open), Encoding.UTF8))
            {
                Console.WriteLine($"int value is {binaryReader.ReadInt32()}");
                Console.WriteLine($"char  value is {binaryReader.ReadChar()}");
                Console.WriteLine($"Boolean value is {binaryReader.ReadBoolean()}");
                Console.WriteLine($"double value is {binaryReader.ReadDouble()}");
                Console.WriteLine(binaryReader.ReadByte());
                Console.WriteLine(binaryReader.Read());
            }
        }

        static void Advanced()
        {
            using (var streamWriteCustomBuffer = new CustomBufferedStreamWriter("customBuffer.txt", 1024))
            {
                for(int i = 0;i<10; i++)
                {
                    streamWriteCustomBuffer.Write(i);
                }
            }
            
        }

    }
}