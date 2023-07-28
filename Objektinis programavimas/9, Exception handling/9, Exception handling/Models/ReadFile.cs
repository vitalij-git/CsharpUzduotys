using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Exception_handling.Models
{
    internal class ReadFile
    {
        public ReadFile(string path) 
        {
            Path = path;
        }
        public string Path { get; set; }

        public void TryReadFile()
        {
            try
            {
                string text = File.ReadAllText(Path, Encoding.UTF8);
                var fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                using (var reader = new StreamReader(fileStream))
                {
                    text = reader.ReadToEnd();
                }
                fileStream.Close();
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file  cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory cannot be found.");
            }


        }
    }
}
